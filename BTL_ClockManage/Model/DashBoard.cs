using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_ClockManage.Db;
using System.Data.SqlClient;


namespace BTL_ClockManage.Models
{
    public struct RevenueByDate
    {
        private DateTime starDate;
        private DateTime endDate;
        private int numbersDays;
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }

    }
    public class DashBoard : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomes { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        // Top san pham ban chay
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }

        public List<KeyValuePair<string, int>> TopStaffsList { get; private set; }
        // San pham co so luong ton kho thap
        public List<KeyValuePair<string, int>> UnderStockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        // constructor
        public DashBoard()
        {

        }
        //private methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Number of Customers
                    command.CommandText = "SELECT COUNT(MAKH) FROM KHACHHANG";
                    NumCustomes = (int)command.ExecuteScalar();
                    //Get Number of Suppliers
                    command.CommandText = "SELECT COUNT(MANCC) FROM NHACUNGCAP";
                    NumSuppliers = (int)command.ExecuteScalar();
                    //Get Number of Products
                    command.CommandText = "SELECT COUNT(MASP) FROM SANPHAM";
                    NumProducts = (int)command.ExecuteScalar();
                    //Get Number of Orders
                    command.CommandText = "SELECT COUNT(SOHD) FROM HOADON WHERE NGAYLAPHOADON BETWEEN @fromDate AND @toDate";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;

                    NumOrders = (int)command.ExecuteScalar();
                }
            }
        }
        private void GetOrderAnaLisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalRevenue = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT NGAYLAPHOADON, SUM(THANHTIENHD) AS TONGHD
                                                    FROM HOADON
                                                    WHERE NGAYLAPHOADON BETWEEN @fromDate AND @toDate
                                                    GROUP BY NGAYLAPHOADON";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                        TotalRevenue += (decimal)reader[1];
                    }
                    reader.Close();

                    // Group by days
                    if (numberDays <= 30)
                    {
                        foreach (var item in resultTable)
                        {
                            GrossRevenueList.Add(new RevenueByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                TotalAmount = item.Value
                            });
                        }
                    }
                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }
                                           ).ToList();
                    }
                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }
                                           ).ToList();
                    }
                    //Group by Years
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }
                                           ).ToList();
                    }
                }
            }
        }


        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"select top 10 P.TENSP, sum(CTHD.SOLUONG) as Q
                                            from CTHD
                                            inner join SANPHAM P on P.MASP = CTHD.MASP
                                            inner
                                            join [HOADON] O on O.SOHD = CTHD.SOHD
                                            where NGAYLAPHOADON between @fromDate and @toDate
                                            group by P.TENSP
                                            order by Q desc ";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get Understock
                    command.CommandText = @"select TENSP, SOLUONG, HinhAnh
                                            from SANPHAM
                                            where SOLUONG <=5 ";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderStockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }

            }

        }
        private void GetProductAnalisys5()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"select top 5 P.TENSP, sum(CTHD.SOLUONG) as Q
                                            from CTHD
                                            inner join SANPHAM P on P.MASP = CTHD.MASP
                                            inner
                                            join [HOADON] O on O.SOHD = CTHD.SOHD
                                            where NGAYLAPHOADON between @fromDate and @toDate
                                            group by P.TENSP
                                            order by Q desc ";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get Understock
                    command.CommandText = @"select TENSP, SOLUONG
                                            from SANPHAM
                                            where SOLUONG <=5 ";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderStockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }

            }

        }

        private void GetStaffs()
        {
            TopStaffsList = new List<KeyValuePair<string, int>>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"select top 3 NHANVIEN.MANV , COUNT(HOADON.SOHD) 
                                            from HOADON join NHANVIEN on HOADON.MANV = NHANVIEN.MANV 
                                            where NGAYLAPHOADON between @fromDate and @toDate
                                            group by NHANVIEN.MANV
                                            order by count(HOADON.SOHD) desc ";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopStaffsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                }

            }

        }


        //Punlic methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnaLisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }

        public bool LoadData2(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GetNumberItems();

                GetOrderAnaLisys();
                GetStaffs();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
        public bool LoadData3(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;
                GetNumberItems();
                GetProductAnalisys5();
                GetOrderAnaLisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }



    }
}

using AForge.Video;
using AForge.Video.DirectShow;
using BTL_ClockManage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace BTL_ClockManage.Views
{
    public partial class viewBillPaying : Form
    {
        public viewBillPaying()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void viewBillPaying_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cbCamera.Items.Add(device.Name);
            cbCamera.SelectedIndex = 1;
            cbStatus.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        public void turnOffCamera()
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.SignalToStop();
                    videoCaptureDevice = null;
                }
            }
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                barcode.Invoke(new MethodInvoker(delegate ()
                {
                    barcode.Text = result.ToString();
                }));
            }
            pic.Image = bitmap;
        }

        private void viewBillPaying_FormClosing(object sender, FormClosingEventArgs e)
        {
            turnOffCamera();
        }

        private void barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            HOADON hd = Program.context.HOADONs.OrderByDescending(n=>n.SOHD).First();
            int id = hd.SOHD + 1;
            txtId.Text = id.ToString();
            HOADON newBill = new HOADON
            {
                SOHD = id,
                MAKH = "KH6",
                MANV = "NVTN001",
                NGAYLAPHOADON = DateTime.Now,
                TRANGTHAI = cbStatus.SelectedItem.ToString()
            };
            Program.context.HOADONs.Add(newBill);
            Program.context.SaveChanges();
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {

        }
    }
}

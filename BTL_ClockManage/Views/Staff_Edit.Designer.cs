namespace BTL_ClockManage
{
    partial class Staff_Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_position = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_position_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_position = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_salary_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_salary = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_salary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_id_card_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_id_card = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_id_card = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbtn_male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtn_female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lbl_gender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_phone_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_address_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_name_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_id_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_phone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_address = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_form2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cb_position
            // 
            this.cb_position.BackColor = System.Drawing.Color.Transparent;
            this.cb_position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_position.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_position.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_position.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_position.ItemHeight = 30;
            this.cb_position.Location = new System.Drawing.Point(157, 520);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(350, 36);
            this.cb_position.TabIndex = 86;
            this.cb_position.SelectedIndexChanged += new System.EventHandler(this.cb_position_SelectedIndexChanged);
            // 
            // lbl_position_empty
            // 
            this.lbl_position_empty.AutoSize = false;
            this.lbl_position_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_position_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_position_empty.Location = new System.Drawing.Point(157, 571);
            this.lbl_position_empty.Name = "lbl_position_empty";
            this.lbl_position_empty.Size = new System.Drawing.Size(133, 19);
            this.lbl_position_empty.TabIndex = 85;
            this.lbl_position_empty.Text = "* Position is empty!";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = false;
            this.lbl_position.BackColor = System.Drawing.Color.Transparent;
            this.lbl_position.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.Location = new System.Drawing.Point(29, 524);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(80, 22);
            this.lbl_position.TabIndex = 84;
            this.lbl_position.Text = "Position:";
            // 
            // lbl_salary_empty
            // 
            this.lbl_salary_empty.AutoSize = false;
            this.lbl_salary_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salary_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salary_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_salary_empty.Location = new System.Drawing.Point(157, 495);
            this.lbl_salary_empty.Name = "lbl_salary_empty";
            this.lbl_salary_empty.Size = new System.Drawing.Size(133, 19);
            this.lbl_salary_empty.TabIndex = 83;
            this.lbl_salary_empty.Text = "* Salary is empty!";
            // 
            // txt_salary
            // 
            this.txt_salary.BorderColor = System.Drawing.Color.Black;
            this.txt_salary.BorderRadius = 3;
            this.txt_salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_salary.DefaultText = "";
            this.txt_salary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_salary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_salary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_salary.Location = new System.Drawing.Point(157, 442);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.PasswordChar = '\0';
            this.txt_salary.PlaceholderText = "";
            this.txt_salary.SelectedText = "";
            this.txt_salary.Size = new System.Drawing.Size(350, 47);
            this.txt_salary.TabIndex = 82;
            this.txt_salary.TextChanged += new System.EventHandler(this.txt_salary_TextChanged);
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = false;
            this.lbl_salary.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salary.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salary.Location = new System.Drawing.Point(29, 457);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(80, 22);
            this.lbl_salary.TabIndex = 81;
            this.lbl_salary.Text = "Salary:";
            // 
            // lbl_id_card_empty
            // 
            this.lbl_id_card_empty.AutoSize = false;
            this.lbl_id_card_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_card_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_card_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_id_card_empty.Location = new System.Drawing.Point(157, 339);
            this.lbl_id_card_empty.Name = "lbl_id_card_empty";
            this.lbl_id_card_empty.Size = new System.Drawing.Size(144, 19);
            this.lbl_id_card_empty.TabIndex = 80;
            this.lbl_id_card_empty.Text = "* ID Card is empty!";
            // 
            // txt_id_card
            // 
            this.txt_id_card.BorderColor = System.Drawing.Color.Black;
            this.txt_id_card.BorderRadius = 3;
            this.txt_id_card.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_card.DefaultText = "";
            this.txt_id_card.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id_card.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id_card.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_card.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id_card.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id_card.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_card.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id_card.Location = new System.Drawing.Point(157, 287);
            this.txt_id_card.Name = "txt_id_card";
            this.txt_id_card.PasswordChar = '\0';
            this.txt_id_card.PlaceholderText = "";
            this.txt_id_card.SelectedText = "";
            this.txt_id_card.Size = new System.Drawing.Size(350, 47);
            this.txt_id_card.TabIndex = 79;
            this.txt_id_card.TextChanged += new System.EventHandler(this.txt_id_card_TextChanged);
            // 
            // lbl_id_card
            // 
            this.lbl_id_card.AutoSize = false;
            this.lbl_id_card.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_card.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_card.Location = new System.Drawing.Point(29, 303);
            this.lbl_id_card.Name = "lbl_id_card";
            this.lbl_id_card.Size = new System.Drawing.Size(96, 22);
            this.lbl_id_card.TabIndex = 78;
            this.lbl_id_card.Text = "ID Card:";
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_male.CheckedState.BorderThickness = 0;
            this.rbtn_male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_male.CheckedState.InnerOffset = -4;
            this.rbtn_male.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.rbtn_male.Location = new System.Drawing.Point(277, 238);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(66, 24);
            this.rbtn_male.TabIndex = 77;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_male.UncheckedState.BorderThickness = 2;
            this.rbtn_male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_female.CheckedState.BorderThickness = 0;
            this.rbtn_female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtn_female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtn_female.CheckedState.InnerOffset = -4;
            this.rbtn_female.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.rbtn_female.Location = new System.Drawing.Point(157, 238);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(82, 24);
            this.rbtn_female.TabIndex = 76;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_female.UncheckedState.BorderThickness = 2;
            this.rbtn_female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = false;
            this.lbl_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gender.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(29, 238);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(80, 22);
            this.lbl_gender.TabIndex = 75;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_phone_empty
            // 
            this.lbl_phone_empty.AutoSize = false;
            this.lbl_phone_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_phone_empty.Location = new System.Drawing.Point(157, 417);
            this.lbl_phone_empty.Name = "lbl_phone_empty";
            this.lbl_phone_empty.Size = new System.Drawing.Size(133, 19);
            this.lbl_phone_empty.TabIndex = 73;
            this.lbl_phone_empty.Text = "* Phone is empty!";
            // 
            // lbl_address_empty
            // 
            this.lbl_address_empty.AutoSize = false;
            this.lbl_address_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_address_empty.Location = new System.Drawing.Point(157, 649);
            this.lbl_address_empty.Name = "lbl_address_empty";
            this.lbl_address_empty.Size = new System.Drawing.Size(144, 19);
            this.lbl_address_empty.TabIndex = 72;
            this.lbl_address_empty.Text = "* Address is empty!";
            // 
            // lbl_name_empty
            // 
            this.lbl_name_empty.AutoSize = false;
            this.lbl_name_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_name_empty.Location = new System.Drawing.Point(157, 201);
            this.lbl_name_empty.Name = "lbl_name_empty";
            this.lbl_name_empty.Size = new System.Drawing.Size(133, 19);
            this.lbl_name_empty.TabIndex = 71;
            this.lbl_name_empty.Text = "* Name is empty!";
            // 
            // lbl_id_empty
            // 
            this.lbl_id_empty.AutoSize = false;
            this.lbl_id_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_id_empty.Location = new System.Drawing.Point(157, 121);
            this.lbl_id_empty.Name = "lbl_id_empty";
            this.lbl_id_empty.Size = new System.Drawing.Size(108, 19);
            this.lbl_id_empty.TabIndex = 70;
            this.lbl_id_empty.Text = "* ID is empty!";
            // 
            // txt_phone
            // 
            this.txt_phone.BorderColor = System.Drawing.Color.Black;
            this.txt_phone.BorderRadius = 3;
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.DefaultText = "";
            this.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Location = new System.Drawing.Point(157, 364);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(350, 47);
            this.txt_phone.TabIndex = 69;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = false;
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(29, 379);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(80, 22);
            this.lbl_phone.TabIndex = 68;
            this.lbl_phone.Text = "Phone:";
            // 
            // txt_address
            // 
            this.txt_address.BorderColor = System.Drawing.Color.Black;
            this.txt_address.BorderRadius = 3;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Location = new System.Drawing.Point(157, 596);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(350, 47);
            this.txt_address.TabIndex = 67;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = false;
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(29, 612);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(96, 22);
            this.lbl_address.TabIndex = 66;
            this.lbl_address.Text = "Address:";
            // 
            // txt_name
            // 
            this.txt_name.BorderColor = System.Drawing.Color.Black;
            this.txt_name.BorderRadius = 3;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(157, 147);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(350, 47);
            this.txt_name.TabIndex = 65;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = false;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(29, 159);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 22);
            this.lbl_name.TabIndex = 64;
            this.lbl_name.Text = "Name:";
            // 
            // txt_id
            // 
            this.txt_id.BorderColor = System.Drawing.Color.Black;
            this.txt_id.BorderRadius = 3;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.DefaultText = "";
            this.txt_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_id.Location = new System.Drawing.Point(157, 68);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(350, 47);
            this.txt_id.TabIndex = 63;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(29, 79);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 22);
            this.lbl_id.TabIndex = 62;
            this.lbl_id.Text = "ID:";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BorderRadius = 4;
            this.btn_minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimize.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_minimize.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(448, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(49, 40);
            this.btn_minimize.TabIndex = 61;
            this.btn_minimize.Text = "-";
            this.btn_minimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_minimize.TextOffset = new System.Drawing.Point(2, -4);
            this.btn_minimize.UseTransparentBackground = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BorderRadius = 4;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(503, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(49, 40);
            this.btn_close.TabIndex = 60;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_add_form2
            // 
            this.btn_add_form2.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_add_form2.BorderRadius = 6;
            this.btn_add_form2.BorderThickness = 1;
            this.btn_add_form2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_form2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_form2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_form2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_form2.FillColor = System.Drawing.Color.OrangeRed;
            this.btn_add_form2.FocusedColor = System.Drawing.SystemColors.Control;
            this.btn_add_form2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_form2.ForeColor = System.Drawing.Color.Black;
            this.btn_add_form2.Image = global::BTL_ClockManage.Properties.Resources.update1;
            this.btn_add_form2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_add_form2.Location = new System.Drawing.Point(372, 678);
            this.btn_add_form2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_form2.Name = "btn_add_form2";
            this.btn_add_form2.Size = new System.Drawing.Size(125, 48);
            this.btn_add_form2.TabIndex = 74;
            this.btn_add_form2.Text = "Update";
            // 
            // Staff_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(580, 739);
            this.Controls.Add(this.cb_position);
            this.Controls.Add(this.lbl_position_empty);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.lbl_salary_empty);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.lbl_id_card_empty);
            this.Controls.Add(this.txt_id_card);
            this.Controls.Add(this.lbl_id_card);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.rbtn_female);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.btn_add_form2);
            this.Controls.Add(this.lbl_phone_empty);
            this.Controls.Add(this.lbl_address_empty);
            this.Controls.Add(this.lbl_name_empty);
            this.Controls.Add(this.lbl_id_empty);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_close);
            this.Name = "Staff_Edit";
            this.Text = "Staff_Edit";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Staff_Edit_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cb_position;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_position_empty;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_position;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_salary_empty;
        private Guna.UI2.WinForms.Guna2TextBox txt_salary;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_salary;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_id_card_empty;
        private Guna.UI2.WinForms.Guna2TextBox txt_id_card;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_id_card;
        private Guna.UI2.WinForms.Guna2RadioButton rbtn_male;
        private Guna.UI2.WinForms.Guna2RadioButton rbtn_female;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_gender;
        private Guna.UI2.WinForms.Guna2Button btn_add_form2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_phone_empty;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_address_empty;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_name_empty;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_id_empty;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_id;
        private Guna.UI2.WinForms.Guna2Button btn_minimize;
        private Guna.UI2.WinForms.Guna2Button btn_close;
    }
}
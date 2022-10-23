namespace BTL_ClockManage
{
    partial class Customer_Add
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
            this.lbl_id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_address = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbtn_female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lbl_id_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_address_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_gender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_phone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_add_form2 = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_phone_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbtn_male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lbl_name_empty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(22, 88);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(26, 22);
            this.lbl_id.TabIndex = 25;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = false;
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(22, 330);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(96, 22);
            this.lbl_address.TabIndex = 29;
            this.lbl_address.Text = "Address:";
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
            this.rbtn_female.Location = new System.Drawing.Point(150, 255);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(82, 24);
            this.rbtn_female.TabIndex = 39;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_female.UncheckedState.BorderThickness = 2;
            this.rbtn_female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lbl_id_empty
            // 
            this.lbl_id_empty.AutoSize = false;
            this.lbl_id_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_id_empty.Location = new System.Drawing.Point(150, 130);
            this.lbl_id_empty.Name = "lbl_id_empty";
            this.lbl_id_empty.Size = new System.Drawing.Size(108, 19);
            this.lbl_id_empty.TabIndex = 33;
            this.lbl_id_empty.Text = "* ID is empty!";
            // 
            // lbl_address_empty
            // 
            this.lbl_address_empty.AutoSize = false;
            this.lbl_address_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_address_empty.Location = new System.Drawing.Point(150, 367);
            this.lbl_address_empty.Name = "lbl_address_empty";
            this.lbl_address_empty.Size = new System.Drawing.Size(144, 19);
            this.lbl_address_empty.TabIndex = 35;
            this.lbl_address_empty.Text = "* Address is empty!";
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
            this.txt_address.Location = new System.Drawing.Point(150, 314);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(350, 47);
            this.txt_address.TabIndex = 30;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
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
            this.txt_id.Location = new System.Drawing.Point(150, 77);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.PlaceholderText = "";
            this.txt_id.SelectedText = "";
            this.txt_id.Size = new System.Drawing.Size(350, 47);
            this.txt_id.TabIndex = 26;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
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
            this.txt_name.Location = new System.Drawing.Point(150, 156);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(350, 47);
            this.txt_name.TabIndex = 28;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
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
            this.txt_phone.Location = new System.Drawing.Point(150, 393);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderText = "";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(350, 47);
            this.txt_phone.TabIndex = 32;
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = false;
            this.lbl_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gender.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.Location = new System.Drawing.Point(22, 255);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(80, 22);
            this.lbl_gender.TabIndex = 38;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = false;
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(22, 408);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(80, 22);
            this.lbl_phone.TabIndex = 31;
            this.lbl_phone.Text = "Phone:";
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
            this.btn_add_form2.Image = global::BTL_ClockManage.Properties.Resources.Add_icon;
            this.btn_add_form2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_add_form2.Location = new System.Drawing.Point(365, 493);
            this.btn_add_form2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_form2.Name = "btn_add_form2";
            this.btn_add_form2.Size = new System.Drawing.Size(125, 48);
            this.btn_add_form2.TabIndex = 37;
            this.btn_add_form2.Text = "Add ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = false;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(22, 168);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 22);
            this.lbl_name.TabIndex = 27;
            this.lbl_name.Text = "Name:";
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
            this.btn_close.Location = new System.Drawing.Point(496, 21);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(49, 40);
            this.btn_close.TabIndex = 23;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_phone_empty
            // 
            this.lbl_phone_empty.AutoSize = false;
            this.lbl_phone_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_phone_empty.Location = new System.Drawing.Point(150, 446);
            this.lbl_phone_empty.Name = "lbl_phone_empty";
            this.lbl_phone_empty.Size = new System.Drawing.Size(133, 19);
            this.lbl_phone_empty.TabIndex = 36;
            this.lbl_phone_empty.Text = "* Phone is empty!";
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
            this.rbtn_male.Location = new System.Drawing.Point(270, 255);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(66, 24);
            this.rbtn_male.TabIndex = 40;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtn_male.UncheckedState.BorderThickness = 2;
            this.rbtn_male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtn_male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lbl_name_empty
            // 
            this.lbl_name_empty.AutoSize = false;
            this.lbl_name_empty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name_empty.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_empty.ForeColor = System.Drawing.Color.Red;
            this.lbl_name_empty.Location = new System.Drawing.Point(150, 210);
            this.lbl_name_empty.Name = "lbl_name_empty";
            this.lbl_name_empty.Size = new System.Drawing.Size(133, 19);
            this.lbl_name_empty.TabIndex = 34;
            this.lbl_name_empty.Text = "* Name is empty!";
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
            this.btn_minimize.Location = new System.Drawing.Point(441, 21);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(49, 40);
            this.btn_minimize.TabIndex = 24;
            this.btn_minimize.Text = "-";
            this.btn_minimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_minimize.TextOffset = new System.Drawing.Point(2, -4);
            this.btn_minimize.UseTransparentBackground = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // Customer_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(567, 563);
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
            this.Name = "Customer_Add";
            this.Text = "Customer_Add";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Customer_Add_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_address;
        private Guna.UI2.WinForms.Guna2RadioButton rbtn_female;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_id_empty;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_address_empty;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_gender;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_phone;
        private Guna.UI2.WinForms.Guna2Button btn_add_form2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_name;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_phone_empty;
        private Guna.UI2.WinForms.Guna2RadioButton rbtn_male;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_name_empty;
        private Guna.UI2.WinForms.Guna2Button btn_minimize;
    }
}
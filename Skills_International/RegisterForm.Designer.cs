namespace Skills_International
{
    partial class RegisterForm
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
            groupBox1 = new GroupBox();
            selectRegno = new ComboBox();
            label13 = new Label();
            btn_update = new Button();
            btn_register = new Button();
            btn_clear = new Button();
            btn_delete = new Button();
            groupBox4 = new GroupBox();
            tb_contactNo = new TextBox();
            tb_nic = new TextBox();
            tb_parentName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox3 = new GroupBox();
            tb_home = new TextBox();
            tb_mobile = new TextBox();
            tb_email = new TextBox();
            address = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            rb_female = new RadioButton();
            rb_male = new RadioButton();
            dob = new DateTimePicker();
            tb_lastName = new TextBox();
            tb_firstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label14 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selectRegno);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btn_update);
            groupBox1.Controls.Add(btn_register);
            groupBox1.Controls.Add(btn_clear);
            groupBox1.Controls.Add(btn_delete);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(40, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 765);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // selectRegno
            // 
            selectRegno.FormattingEnabled = true;
            selectRegno.Location = new Point(204, 36);
            selectRegno.Name = "selectRegno";
            selectRegno.Size = new Size(157, 31);
            selectRegno.TabIndex = 10;
            selectRegno.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(82, 39);
            label13.Name = "label13";
            label13.Size = new Size(67, 23);
            label13.TabIndex = 4;
            label13.Text = "Reg No";
            // 
            // btn_update
            // 
            btn_update.Location = new Point(132, 705);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 42);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(32, 705);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(94, 42);
            btn_register.TabIndex = 8;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(457, 705);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 42);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(557, 705);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 42);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tb_contactNo);
            groupBox4.Controls.Add(tb_nic);
            groupBox4.Controls.Add(tb_parentName);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(32, 509);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(619, 181);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            // 
            // tb_contactNo
            // 
            tb_contactNo.Location = new Point(172, 123);
            tb_contactNo.Name = "tb_contactNo";
            tb_contactNo.Size = new Size(250, 30);
            tb_contactNo.TabIndex = 10;
            // 
            // tb_nic
            // 
            tb_nic.Location = new Point(172, 82);
            tb_nic.Name = "tb_nic";
            tb_nic.Size = new Size(250, 30);
            tb_nic.TabIndex = 9;
            // 
            // tb_parentName
            // 
            tb_parentName.Location = new Point(172, 43);
            tb_parentName.Name = "tb_parentName";
            tb_parentName.Size = new Size(414, 30);
            tb_parentName.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 165);
            label9.Name = "label9";
            label9.Size = new Size(0, 23);
            label9.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 126);
            label10.Name = "label10";
            label10.Size = new Size(98, 23);
            label10.TabIndex = 2;
            label10.Text = "Contact No";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 85);
            label11.Name = "label11";
            label11.Size = new Size(39, 23);
            label11.TabIndex = 1;
            label11.Text = "NIC";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 46);
            label12.Name = "label12";
            label12.Size = new Size(110, 23);
            label12.TabIndex = 0;
            label12.Text = "Parent Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tb_home);
            groupBox3.Controls.Add(tb_mobile);
            groupBox3.Controls.Add(tb_email);
            groupBox3.Controls.Add(address);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(32, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(619, 218);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // tb_home
            // 
            tb_home.Location = new Point(430, 158);
            tb_home.Name = "tb_home";
            tb_home.Size = new Size(165, 30);
            tb_home.TabIndex = 7;
            // 
            // tb_mobile
            // 
            tb_mobile.Location = new Point(172, 154);
            tb_mobile.Name = "tb_mobile";
            tb_mobile.Size = new Size(136, 30);
            tb_mobile.TabIndex = 6;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(172, 108);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(423, 30);
            tb_email.TabIndex = 5;
            // 
            // address
            // 
            address.Location = new Point(172, 40);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(423, 58);
            address.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 161);
            label5.Name = "label5";
            label5.Size = new Size(110, 23);
            label5.TabIndex = 3;
            label5.Text = "Home Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 161);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 2;
            label6.Text = "Mobile Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 115);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 1;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 43);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 0;
            label8.Text = "Address";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rb_female);
            groupBox2.Controls.Add(rb_male);
            groupBox2.Controls.Add(dob);
            groupBox2.Controls.Add(tb_lastName);
            groupBox2.Controls.Add(tb_firstName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(32, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(619, 204);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // rb_female
            // 
            rb_female.AutoSize = true;
            rb_female.Location = new Point(278, 161);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(85, 27);
            rb_female.TabIndex = 8;
            rb_female.TabStop = true;
            rb_female.Text = "Female";
            rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            rb_male.AutoSize = true;
            rb_male.Location = new Point(172, 161);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(68, 27);
            rb_male.TabIndex = 7;
            rb_male.TabStop = true;
            rb_male.Text = "Male";
            rb_male.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            dob.Format = DateTimePickerFormat.Short;
            dob.Location = new Point(172, 114);
            dob.Name = "dob";
            dob.Size = new Size(157, 30);
            dob.TabIndex = 6;
            dob.Value = new DateTime(2024, 12, 5, 12, 7, 44, 0);
            // 
            // tb_lastName
            // 
            tb_lastName.Location = new Point(172, 76);
            tb_lastName.Name = "tb_lastName";
            tb_lastName.Size = new Size(423, 30);
            tb_lastName.TabIndex = 5;
            // 
            // tb_firstName
            // 
            tb_firstName.Location = new Point(172, 36);
            tb_firstName.Name = "tb_firstName";
            tb_firstName.Size = new Size(423, 30);
            tb_firstName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 163);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 120);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 79);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(708, 836);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 28);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Exit";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(12, 9);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 28);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Logout";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(212, 9);
            label14.Name = "label14";
            label14.Size = new Size(417, 60);
            label14.TabIndex = 3;
            label14.Text = "Skills International";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(763, 867);
            Controls.Add(label14);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            Load += RegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_update;
        private Button btn_register;
        private Button btn_clear;
        private Button btn_delete;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label13;
        private ComboBox selectRegno;
        private TextBox tb_lastName;
        private TextBox tb_firstName;
        private TextBox tb_email;
        private TextBox address;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private DateTimePicker dob;
        private TextBox tb_contactNo;
        private TextBox tb_nic;
        private TextBox tb_parentName;
        private TextBox tb_home;
        private TextBox tb_mobile;
        private Label label14;
    }
}
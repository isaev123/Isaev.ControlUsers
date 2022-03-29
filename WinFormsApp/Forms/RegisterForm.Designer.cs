namespace WinFormsApp.Forms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelFlat = new System.Windows.Forms.Label();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.labelHouse = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelConfirmPassword);
            this.groupBox1.Controls.Add(this.textBoxConfirmPassword);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.labelLogin);
            this.groupBox1.Controls.Add(this.textBoxLogin);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основное";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(6, 107);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(123, 15);
            this.labelConfirmPassword.TabIndex = 5;
            this.labelConfirmPassword.Text = "Подтвердите пароль:";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(6, 125);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(235, 23);
            this.textBoxConfirmPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 63);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(52, 15);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPassword.Location = new System.Drawing.Point(6, 81);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(235, 23);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 19);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(44, 15);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLogin.Location = new System.Drawing.Point(6, 37);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(235, 23);
            this.textBoxLogin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDateOfBirth);
            this.groupBox2.Controls.Add(this.dateTimePickerDateOfBirth);
            this.groupBox2.Controls.Add(this.comboBoxGender);
            this.groupBox2.Controls.Add(this.labelGender);
            this.groupBox2.Controls.Add(this.labelMiddleName);
            this.groupBox2.Controls.Add(this.textBoxMiddleName);
            this.groupBox2.Controls.Add(this.labelFirstName);
            this.groupBox2.Controls.Add(this.textBoxFirstName);
            this.groupBox2.Controls.Add(this.labelLastName);
            this.groupBox2.Controls.Add(this.textBoxLastName);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пользователь";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(6, 151);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(93, 15);
            this.labelDateOfBirth.TabIndex = 19;
            this.labelDateOfBirth.Text = "Дата рождения:";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "";
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(6, 169);
            this.dateTimePickerDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(235, 23);
            this.dateTimePickerDateOfBirth.TabIndex = 18;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2022, 3, 28, 19, 25, 0, 0);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(7, 213);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(235, 23);
            this.comboBoxGender.TabIndex = 17;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(7, 195);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(33, 15);
            this.labelGender.TabIndex = 16;
            this.labelGender.Text = "Пол:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(6, 107);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(61, 15);
            this.labelMiddleName.TabIndex = 11;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMiddleName.Location = new System.Drawing.Point(6, 125);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(235, 23);
            this.textBoxMiddleName.TabIndex = 10;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 63);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(34, 15);
            this.labelFirstName.TabIndex = 9;
            this.labelFirstName.Text = "Имя:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFirstName.Location = new System.Drawing.Point(6, 81);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(235, 23);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 19);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 15);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Фамилия:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLastName.Location = new System.Drawing.Point(6, 37);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(235, 23);
            this.textBoxLastName.TabIndex = 6;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(6, 59);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(104, 15);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "Номер телефона:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPhone.Location = new System.Drawing.Point(2, 77);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(235, 23);
            this.textBoxPhone.TabIndex = 14;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 15);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(153, 15);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Адрес электронной почты";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmail.Location = new System.Drawing.Point(2, 33);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(235, 23);
            this.textBoxEmail.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxCity);
            this.groupBox3.Controls.Add(this.textBoxComment);
            this.groupBox3.Controls.Add(this.labelComment);
            this.groupBox3.Controls.Add(this.labelFlat);
            this.groupBox3.Controls.Add(this.textBoxFlat);
            this.groupBox3.Controls.Add(this.labelHouse);
            this.groupBox3.Controls.Add(this.textBoxHouse);
            this.groupBox3.Controls.Add(this.labelStreet);
            this.groupBox3.Controls.Add(this.textBoxStreet);
            this.groupBox3.Controls.Add(this.labelCity);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(265, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 275);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Дополнительная информация";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(6, 37);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(235, 23);
            this.comboBoxCity.TabIndex = 16;
            // 
            // textBoxComment
            // 
            this.textBoxComment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxComment.Location = new System.Drawing.Point(6, 213);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(235, 44);
            this.textBoxComment.TabIndex = 15;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(6, 195);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(136, 15);
            this.labelComment.TabIndex = 14;
            this.labelComment.Text = "Комментарий к адресу:";
            // 
            // labelFlat
            // 
            this.labelFlat.AutoSize = true;
            this.labelFlat.Location = new System.Drawing.Point(6, 151);
            this.labelFlat.Name = "labelFlat";
            this.labelFlat.Size = new System.Drawing.Size(61, 15);
            this.labelFlat.TabIndex = 13;
            this.labelFlat.Text = "Квартира:";
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFlat.Location = new System.Drawing.Point(6, 169);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(235, 23);
            this.textBoxFlat.TabIndex = 12;
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new System.Drawing.Point(6, 107);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(34, 15);
            this.labelHouse.TabIndex = 11;
            this.labelHouse.Text = "Дом:";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHouse.Location = new System.Drawing.Point(6, 125);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(235, 23);
            this.textBoxHouse.TabIndex = 10;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(6, 63);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(44, 15);
            this.labelStreet.TabIndex = 9;
            this.labelStreet.Text = "Улица:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxStreet.Location = new System.Drawing.Point(6, 81);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(235, 23);
            this.textBoxStreet.TabIndex = 8;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(6, 19);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(115, 15);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "Город проживания:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegister.Location = new System.Drawing.Point(265, 407);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(249, 32);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelPhone);
            this.groupBox4.Controls.Add(this.textBoxPhone);
            this.groupBox4.Controls.Add(this.labelEmail);
            this.groupBox4.Controls.Add(this.textBoxEmail);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Location = new System.Drawing.Point(265, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 108);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Контактная информация";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(526, 449);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label labelConfirmPassword;
        private TextBox textBoxConfirmPassword;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelLogin;
        private TextBox textBoxLogin;
        private GroupBox groupBox2;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelMiddleName;
        private TextBox textBoxMiddleName;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private ComboBox comboBoxGender;
        private Label labelGender;
        private GroupBox groupBox3;
        private Label labelFlat;
        private TextBox textBoxFlat;
        private Label labelHouse;
        private TextBox textBoxHouse;
        private Label labelStreet;
        private TextBox textBoxStreet;
        private Label labelCity;
        private Label labelDateOfBirth;
        private DateTimePicker dateTimePickerDateOfBirth;
        private TextBox textBoxComment;
        private Label labelComment;
        private Button buttonRegister;
        private GroupBox groupBox4;
        private ComboBox comboBoxCity;
    }
}
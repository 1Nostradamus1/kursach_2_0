namespace kursach_2_0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonRegistration = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.UserSerName = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Labelfinish = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelExit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(238, 272);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(327, 41);
            this.PhoneNumber.TabIndex = 14;
            this.PhoneNumber.Enter += new System.EventHandler(this.PhoneNumber_Enter);
            this.PhoneNumber.Leave += new System.EventHandler(this.PhoneNumber_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Регистрация\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegistration.Location = new System.Drawing.Point(321, 342);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(170, 33);
            this.ButtonRegistration.TabIndex = 12;
            this.ButtonRegistration.Text = "Создать аккаунт";
            this.ButtonRegistration.UseVisualStyleBackColor = true;
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonRegistration_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(41, 204);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(327, 41);
            this.Password.TabIndex = 10;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(41, 123);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(327, 41);
            this.Login.TabIndex = 8;
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // UserSerName
            // 
            this.UserSerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSerName.Location = new System.Drawing.Point(440, 204);
            this.UserSerName.Name = "UserSerName";
            this.UserSerName.Size = new System.Drawing.Size(327, 41);
            this.UserSerName.TabIndex = 17;
            this.UserSerName.Enter += new System.EventHandler(this.UserSerName_Enter);
            this.UserSerName.Leave += new System.EventHandler(this.UserSerName_Leave);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(440, 123);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(327, 41);
            this.Username.TabIndex = 16;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Labelfinish
            // 
            this.Labelfinish.AutoSize = true;
            this.Labelfinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Labelfinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelfinish.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Labelfinish.Location = new System.Drawing.Point(345, 405);
            this.Labelfinish.Name = "Labelfinish";
            this.Labelfinish.Size = new System.Drawing.Size(124, 16);
            this.Labelfinish.TabIndex = 18;
            this.Labelfinish.Text = "Уже есть аккаунт!";
            this.Labelfinish.Click += new System.EventHandler(this.Labelfinish_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabelExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(277, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Телефонный справочник";
            // 
            // LabelExit
            // 
            this.LabelExit.AutoSize = true;
            this.LabelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelExit.Location = new System.Drawing.Point(774, 0);
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Size = new System.Drawing.Size(23, 25);
            this.LabelExit.TabIndex = 0;
            this.LabelExit.Text = "х";
            this.LabelExit.Click += new System.EventHandler(this.LabelExit_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Labelfinish);
            this.Controls.Add(this.UserSerName);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonRegistration);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonRegistration;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox UserSerName;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label Labelfinish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelExit;
        private System.Windows.Forms.Label label1;
    }
}
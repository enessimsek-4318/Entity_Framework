namespace ACD_Construction
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_showHide = new System.Windows.Forms.Button();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_document = new System.Windows.Forms.RadioButton();
            this.rbtn_letter = new System.Windows.Forms.RadioButton();
            this.rbtn_register = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Location = new System.Drawing.Point(341, 119);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(56, 27);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // btn_showHide
            // 
            this.btn_showHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_showHide.BackgroundImage")));
            this.btn_showHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_showHide.Location = new System.Drawing.Point(361, 42);
            this.btn_showHide.Margin = new System.Windows.Forms.Padding(2);
            this.btn_showHide.Name = "btn_showHide";
            this.btn_showHide.Size = new System.Drawing.Size(33, 28);
            this.btn_showHide.TabIndex = 12;
            this.btn_showHide.UseVisualStyleBackColor = true;
            this.btn_showHide.Click += new System.EventHandler(this.btn_showHide_Click_1);
            // 
            // loginPicture
            // 
            this.loginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginPicture.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.loginPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginPicture.Image")));
            this.loginPicture.Location = new System.Drawing.Point(11, 11);
            this.loginPicture.Margin = new System.Windows.Forms.Padding(2);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(120, 130);
            this.loginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPicture.TabIndex = 11;
            this.loginPicture.TabStop = false;
            this.loginPicture.UseWaitCursor = true;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.Location = new System.Drawing.Point(216, 44);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(141, 23);
            this.txt_password.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(136, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // txt_userName
            // 
            this.txt_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_userName.Location = new System.Drawing.Point(216, 11);
            this.txt_userName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(141, 23);
            this.txt_userName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "User Name:";
            // 
            // rbtn_document
            // 
            this.rbtn_document.AutoSize = true;
            this.rbtn_document.Location = new System.Drawing.Point(182, 78);
            this.rbtn_document.Name = "rbtn_document";
            this.rbtn_document.Size = new System.Drawing.Size(74, 17);
            this.rbtn_document.TabIndex = 14;
            this.rbtn_document.TabStop = true;
            this.rbtn_document.Text = "Document";
            this.rbtn_document.UseVisualStyleBackColor = true;
            // 
            // rbtn_letter
            // 
            this.rbtn_letter.AutoSize = true;
            this.rbtn_letter.Location = new System.Drawing.Point(260, 78);
            this.rbtn_letter.Name = "rbtn_letter";
            this.rbtn_letter.Size = new System.Drawing.Size(52, 17);
            this.rbtn_letter.TabIndex = 15;
            this.rbtn_letter.TabStop = true;
            this.rbtn_letter.Text = "Letter";
            this.rbtn_letter.UseVisualStyleBackColor = true;
            // 
            // rbtn_register
            // 
            this.rbtn_register.AutoSize = true;
            this.rbtn_register.Location = new System.Drawing.Point(317, 78);
            this.rbtn_register.Name = "rbtn_register";
            this.rbtn_register.Size = new System.Drawing.Size(64, 17);
            this.rbtn_register.TabIndex = 17;
            this.rbtn_register.TabStop = true;
            this.rbtn_register.Text = "Register";
            this.rbtn_register.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 156);
            this.Controls.Add(this.rbtn_register);
            this.Controls.Add(this.rbtn_letter);
            this.Controls.Add(this.rbtn_document);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_showHide);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_showHide;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_document;
        private System.Windows.Forms.RadioButton rbtn_letter;
        private System.Windows.Forms.RadioButton rbtn_register;
    }
}


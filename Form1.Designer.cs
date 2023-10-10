namespace LoginCode2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.ChBShowPassword = new System.Windows.Forms.CheckBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(544, 79);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(222, 31);
            this.TxtUsername.TabIndex = 3;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(544, 142);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(222, 31);
            this.TxtPassword.TabIndex = 4;
            // 
            // ChBShowPassword
            // 
            this.ChBShowPassword.AutoSize = true;
            this.ChBShowPassword.Location = new System.Drawing.Point(544, 205);
            this.ChBShowPassword.Name = "ChBShowPassword";
            this.ChBShowPassword.Size = new System.Drawing.Size(197, 29);
            this.ChBShowPassword.TabIndex = 5;
            this.ChBShowPassword.Text = "Show Password";
            this.ChBShowPassword.UseVisualStyleBackColor = true;
            this.ChBShowPassword.CheckedChanged += new System.EventHandler(this.ChBShowPassword_CheckedChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(649, 315);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(117, 56);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(409, 303);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(117, 56);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.ChBShowPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.CheckBox ChBShowPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCancel;
    }
}


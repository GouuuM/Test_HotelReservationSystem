namespace Test_HotelReservationSystem
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground2 = new System.Windows.Forms.PictureBox();
            this.textBoxLogoName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(1152, 22);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(99, 34);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Log in";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSignUp.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignUp.FlatAppearance.BorderSize = 0;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.White;
            this.buttonSignUp.Location = new System.Drawing.Point(1049, 22);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(97, 34);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxLogoName);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.buttonSignUp);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 63);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.Image = global::Test_HotelReservationSystem.Properties.Resources.Logo2;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-90, -14);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(337, 98);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxBackground2
            // 
            this.pictureBoxBackground2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBackground2.Image = global::Test_HotelReservationSystem.Properties.Resources.Background2;
            this.pictureBoxBackground2.Location = new System.Drawing.Point(-1, -13);
            this.pictureBoxBackground2.Name = "pictureBoxBackground2";
            this.pictureBoxBackground2.Size = new System.Drawing.Size(1280, 720);
            this.pictureBoxBackground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackground2.TabIndex = 0;
            this.pictureBoxBackground2.TabStop = false;
            // 
            // textBoxLogoName
            // 
            this.textBoxLogoName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogoName.BackColor = System.Drawing.Color.White;
            this.textBoxLogoName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogoName.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxLogoName.Enabled = false;
            this.textBoxLogoName.Font = new System.Drawing.Font("Segoe UI Historic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogoName.Location = new System.Drawing.Point(121, 9);
            this.textBoxLogoName.Name = "textBoxLogoName";
            this.textBoxLogoName.Size = new System.Drawing.Size(226, 44);
            this.textBoxLogoName.TabIndex = 7;
            this.textBoxLogoName.Text = "Byte Lodge";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxBackground2);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackground2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLogoName;
    }
}

namespace WindowsFormsApp1
{
    partial class LoginScreen
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
            this.bLogin = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lIncorrect = new System.Windows.Forms.Label();
            this.bLogOut = new System.Windows.Forms.Button();
            this.pPanel = new System.Windows.Forms.Panel();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            this.pPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.Bisque;
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLogin.Location = new System.Drawing.Point(288, 258);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(225, 60);
            this.bLogin.TabIndex = 0;
            this.bLogin.Tag = "";
            this.bLogin.Text = "Log In";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.SystemColors.Info;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(206, 84);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(400, 36);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Tag = "tbLogin";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Info;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(206, 162);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(400, 36);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Tag = "tbPassward";
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLogin.Location = new System.Drawing.Point(64, 80);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(110, 39);
            this.lLogin.TabIndex = 3;
            this.lLogin.Tag = "";
            this.lLogin.Text = "Login:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPassword.Location = new System.Drawing.Point(12, 158);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(176, 39);
            this.lPassword.TabIndex = 4;
            this.lPassword.Tag = "";
            this.lPassword.Text = "Password:";
            // 
            // lIncorrect
            // 
            this.lIncorrect.AutoSize = true;
            this.lIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lIncorrect.Location = new System.Drawing.Point(184, 354);
            this.lIncorrect.Name = "lIncorrect";
            this.lIncorrect.Size = new System.Drawing.Size(440, 39);
            this.lIncorrect.TabIndex = 5;
            this.lIncorrect.Tag = "";
            this.lIncorrect.Text = "Incorrect Login or Password";
            // 
            // bLogOut
            // 
            this.bLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bLogOut.Location = new System.Drawing.Point(886, 7);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(75, 29);
            this.bLogOut.TabIndex = 0;
            this.bLogOut.Text = "Log Out";
            this.bLogOut.UseVisualStyleBackColor = false;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // pPanel
            // 
            this.pPanel.Controls.Add(this.bLogOut);
            this.pPanel.Location = new System.Drawing.Point(5, 12);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(964, 510);
            this.pPanel.TabIndex = 6;
            this.pPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pPanel_Paint);
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPassword.Location = new System.Drawing.Point(652, 174);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(145, 24);
            this.cbPassword.TabIndex = 7;
            this.cbPassword.Text = "Hide Password";
            this.cbPassword.UseVisualStyleBackColor = true;
            this.cbPassword.CheckedChanged += new System.EventHandler(this.cbPassword_CheckedChanged);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(981, 517);
            this.Controls.Add(this.cbPassword);
            this.Controls.Add(this.lIncorrect);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.pPanel);
            this.Name = "LoginScreen";
            this.Tag = "pLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lIncorrect;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Panel pPanel;
        private System.Windows.Forms.CheckBox cbPassword;
    }
}
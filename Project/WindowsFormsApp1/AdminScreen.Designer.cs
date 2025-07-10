
namespace WindowsFormsApp1
{
    partial class AdminScreen
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
            this.bDeactivate = new System.Windows.Forms.Button();
            this.bNewUser = new System.Windows.Forms.Button();
            this.pPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bDeactivate
            // 
            this.bDeactivate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bDeactivate.Location = new System.Drawing.Point(12, 93);
            this.bDeactivate.Name = "bDeactivate";
            this.bDeactivate.Size = new System.Drawing.Size(99, 43);
            this.bDeactivate.TabIndex = 10;
            this.bDeactivate.Text = "Deactivate a user";
            this.bDeactivate.UseVisualStyleBackColor = false;
            this.bDeactivate.Click += new System.EventHandler(this.bDeactivate_Click);
            // 
            // bNewUser
            // 
            this.bNewUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bNewUser.Location = new System.Drawing.Point(12, 23);
            this.bNewUser.Name = "bNewUser";
            this.bNewUser.Size = new System.Drawing.Size(99, 43);
            this.bNewUser.TabIndex = 9;
            this.bNewUser.Text = "Setup New User";
            this.bNewUser.UseVisualStyleBackColor = false;
            this.bNewUser.Click += new System.EventHandler(this.bNewUser_Click);
            // 
            // pPanel
            // 
            this.pPanel.Location = new System.Drawing.Point(117, 5);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(744, 433);
            this.pPanel.TabIndex = 7;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.bDeactivate);
            this.Controls.Add(this.bNewUser);
            this.Controls.Add(this.pPanel);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bDeactivate;
        private System.Windows.Forms.Button bNewUser;
        private System.Windows.Forms.Panel pPanel;
    }
}
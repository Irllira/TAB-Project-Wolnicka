
namespace WindowsFormsApp1
{
    partial class DeactivateUserScreen
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.bDeactivate = new System.Windows.Forms.Button();
            this.lMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lSelectedUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUsers.Location = new System.Drawing.Point(83, 55);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(602, 231);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bDeactivate
            // 
            this.bDeactivate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bDeactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDeactivate.Location = new System.Drawing.Point(189, 315);
            this.bDeactivate.Name = "bDeactivate";
            this.bDeactivate.Size = new System.Drawing.Size(113, 60);
            this.bDeactivate.TabIndex = 2;
            this.bDeactivate.Text = "Deactivate User";
            this.bDeactivate.UseVisualStyleBackColor = false;
            this.bDeactivate.Click += new System.EventHandler(this.bDeactivate_Click);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lMessage.Location = new System.Drawing.Point(335, 389);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(53, 20);
            this.lMessage.TabIndex = 3;
            this.lMessage.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(371, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected User: ";
            // 
            // lSelectedUser
            // 
            this.lSelectedUser.AutoSize = true;
            this.lSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSelectedUser.Location = new System.Drawing.Point(555, 328);
            this.lSelectedUser.Name = "lSelectedUser";
            this.lSelectedUser.Size = new System.Drawing.Size(120, 29);
            this.lSelectedUser.TabIndex = 5;
            this.lSelectedUser.Text = "username";
            // 
            // DeactivateUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSelectedUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.bDeactivate);
            this.Controls.Add(this.dgvUsers);
            this.Name = "DeactivateUserScreen";
            this.Text = "DeactivateUserScreen";
            this.Load += new System.EventHandler(this.DeactivateUserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button bDeactivate;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSelectedUser;
    }
}
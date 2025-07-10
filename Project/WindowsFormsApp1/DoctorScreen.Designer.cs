
namespace WindowsFormsApp1
{
    partial class DoctorScreen
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
            this.bVisit = new System.Windows.Forms.Button();
            this.bPersonalData = new System.Windows.Forms.Button();
            this.pPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbLookUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bVisit
            // 
            this.bVisit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bVisit.Location = new System.Drawing.Point(12, 95);
            this.bVisit.Name = "bVisit";
            this.bVisit.Size = new System.Drawing.Size(158, 31);
            this.bVisit.TabIndex = 5;
            this.bVisit.Text = "Find Visits";
            this.bVisit.UseVisualStyleBackColor = false;
            this.bVisit.Click += new System.EventHandler(this.bVisit_Click);
            // 
            // bPersonalData
            // 
            this.bPersonalData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bPersonalData.Location = new System.Drawing.Point(10, 427);
            this.bPersonalData.Name = "bPersonalData";
            this.bPersonalData.Size = new System.Drawing.Size(159, 37);
            this.bPersonalData.TabIndex = 4;
            this.bPersonalData.Text = "Personal Data";
            this.bPersonalData.UseVisualStyleBackColor = false;
            this.bPersonalData.Click += new System.EventHandler(this.bPersonalData_Click);
            // 
            // pPanel
            // 
            this.pPanel.Location = new System.Drawing.Point(177, 12);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(791, 466);
            this.pPanel.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 276);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbLookUp
            // 
            this.tbLookUp.Location = new System.Drawing.Point(11, 37);
            this.tbLookUp.Name = "tbLookUp";
            this.tbLookUp.Size = new System.Drawing.Size(158, 22);
            this.tbLookUp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Registered",
            "Completed",
            "Cancelled"});
            this.comboBox1.Location = new System.Drawing.Point(11, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DoctorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(980, 486);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLookUp);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bVisit);
            this.Controls.Add(this.bPersonalData);
            this.Controls.Add(this.pPanel);
            this.Name = "DoctorScreen";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.DoctorScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bVisit;
        private System.Windows.Forms.Button bPersonalData;
        private System.Windows.Forms.Panel pPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbLookUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
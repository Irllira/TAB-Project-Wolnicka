
namespace WindowsFormsApp1
{
    partial class PatientScreen
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
            this.pPanel = new System.Windows.Forms.Panel();
            this.bPersonalData = new System.Windows.Forms.Button();
            this.bNewVisit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pPanel
            // 
            this.pPanel.Location = new System.Drawing.Point(123, 4);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(665, 434);
            this.pPanel.TabIndex = 0;
            // 
            // bPersonalData
            // 
            this.bPersonalData.Location = new System.Drawing.Point(12, 395);
            this.bPersonalData.Name = "bPersonalData";
            this.bPersonalData.Size = new System.Drawing.Size(99, 43);
            this.bPersonalData.TabIndex = 1;
            this.bPersonalData.Text = "Personal Data";
            this.bPersonalData.UseVisualStyleBackColor = true;
            this.bPersonalData.Click += new System.EventHandler(this.bPersonalData_Click);
            // 
            // bNewVisit
            // 
            this.bNewVisit.Location = new System.Drawing.Point(12, 12);
            this.bNewVisit.Name = "bNewVisit";
            this.bNewVisit.Size = new System.Drawing.Size(99, 43);
            this.bNewVisit.TabIndex = 2;
            this.bNewVisit.Text = "Setup New Visit";
            this.bNewVisit.UseVisualStyleBackColor = true;
            this.bNewVisit.Click += new System.EventHandler(this.bNewVisit_Click);
            // 
            // PatientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bNewVisit);
            this.Controls.Add(this.bPersonalData);
            this.Controls.Add(this.pPanel);
            this.Name = "PatientScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPanel;
        private System.Windows.Forms.Button bPersonalData;
        private System.Windows.Forms.Button bNewVisit;
    }
}
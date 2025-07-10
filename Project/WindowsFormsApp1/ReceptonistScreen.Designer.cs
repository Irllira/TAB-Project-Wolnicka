
namespace WindowsFormsApp1
{
    partial class ReceptonistScreen
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
            this.bNewVisit = new System.Windows.Forms.Button();
            this.bPersonalData = new System.Windows.Forms.Button();
            this.pPanel = new System.Windows.Forms.Panel();
            this.bPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNewVisit
            // 
            this.bNewVisit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bNewVisit.Location = new System.Drawing.Point(12, 28);
            this.bNewVisit.Name = "bNewVisit";
            this.bNewVisit.Size = new System.Drawing.Size(99, 43);
            this.bNewVisit.TabIndex = 5;
            this.bNewVisit.Text = "Setup New Visit";
            this.bNewVisit.UseVisualStyleBackColor = false;
            this.bNewVisit.Click += new System.EventHandler(this.bNewVisit_Click);
            // 
            // bPersonalData
            // 
            this.bPersonalData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bPersonalData.Location = new System.Drawing.Point(12, 435);
            this.bPersonalData.Name = "bPersonalData";
            this.bPersonalData.Size = new System.Drawing.Size(99, 43);
            this.bPersonalData.TabIndex = 4;
            this.bPersonalData.Text = "Personal Data";
            this.bPersonalData.UseVisualStyleBackColor = false;
            this.bPersonalData.Click += new System.EventHandler(this.bPersonalData_Click);
            // 
            // pPanel
            // 
            this.pPanel.Location = new System.Drawing.Point(123, 8);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(745, 490);
            this.pPanel.TabIndex = 3;
            // 
            // bPatient
            // 
            this.bPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bPatient.Location = new System.Drawing.Point(12, 88);
            this.bPatient.Name = "bPatient";
            this.bPatient.Size = new System.Drawing.Size(99, 43);
            this.bPatient.TabIndex = 6;
            this.bPatient.Text = "Setup New Patient";
            this.bPatient.UseVisualStyleBackColor = false;
            this.bPatient.Click += new System.EventHandler(this.bPatient_Click);
            // 
            // ReceptonistScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(880, 523);
            this.Controls.Add(this.bPatient);
            this.Controls.Add(this.bNewVisit);
            this.Controls.Add(this.bPersonalData);
            this.Controls.Add(this.pPanel);
            this.Name = "ReceptonistScreen";
            this.Text = "Receptonist";
            this.Load += new System.EventHandler(this.ReceptonistScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNewVisit;
        private System.Windows.Forms.Button bPersonalData;
        private System.Windows.Forms.Panel pPanel;
        private System.Windows.Forms.Button bPatient;
    }
}
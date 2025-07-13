
namespace WindowsFormsApp1
{
    partial class SetupVisitScreen
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
            this.bSetupVisit = new System.Windows.Forms.Button();
            this.lbPatients = new System.Windows.Forms.ListBox();
            this.lbDoctor = new System.Windows.Forms.ListBox();
            this.lChoosePatient = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lPatientInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lDoctorInfo = new System.Windows.Forms.Label();
            this.lWarning = new System.Windows.Forms.Label();
            this.tbVisitDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPatientLookUp = new System.Windows.Forms.TextBox();
            this.tbDoctorLookUp = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSetupVisit
            // 
            this.bSetupVisit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSetupVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSetupVisit.Location = new System.Drawing.Point(217, 384);
            this.bSetupVisit.Name = "bSetupVisit";
            this.bSetupVisit.Size = new System.Drawing.Size(128, 49);
            this.bSetupVisit.TabIndex = 0;
            this.bSetupVisit.Text = "Setup Visit";
            this.bSetupVisit.UseVisualStyleBackColor = false;
            this.bSetupVisit.Click += new System.EventHandler(this.bSetupVisit_Click);
            // 
            // lbPatients
            // 
            this.lbPatients.FormattingEnabled = true;
            this.lbPatients.ItemHeight = 16;
            this.lbPatients.Location = new System.Drawing.Point(41, 242);
            this.lbPatients.Name = "lbPatients";
            this.lbPatients.Size = new System.Drawing.Size(141, 84);
            this.lbPatients.TabIndex = 1;
            this.lbPatients.SelectedIndexChanged += new System.EventHandler(this.lbPatients_SelectedIndexChanged);
            // 
            // lbDoctor
            // 
            this.lbDoctor.FormattingEnabled = true;
            this.lbDoctor.ItemHeight = 16;
            this.lbDoctor.Location = new System.Drawing.Point(41, 80);
            this.lbDoctor.Name = "lbDoctor";
            this.lbDoctor.Size = new System.Drawing.Size(141, 84);
            this.lbDoctor.TabIndex = 2;
            this.lbDoctor.SelectedIndexChanged += new System.EventHandler(this.lbDoctor_SelectedIndexChanged);
            // 
            // lChoosePatient
            // 
            this.lChoosePatient.AutoSize = true;
            this.lChoosePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lChoosePatient.Location = new System.Drawing.Point(39, 180);
            this.lChoosePatient.Name = "lChoosePatient";
            this.lChoosePatient.Size = new System.Drawing.Size(146, 25);
            this.lChoosePatient.TabIndex = 3;
            this.lChoosePatient.Text = "Choose Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Doctor";
            // 
            // lPatientInfo
            // 
            this.lPatientInfo.AutoSize = true;
            this.lPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPatientInfo.Location = new System.Drawing.Point(476, 58);
            this.lPatientInfo.Name = "lPatientInfo";
            this.lPatientInfo.Size = new System.Drawing.Size(44, 25);
            this.lPatientInfo.TabIndex = 5;
            this.lPatientInfo.Text = "Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(476, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(257, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doctor Info";
            // 
            // lDoctorInfo
            // 
            this.lDoctorInfo.AutoSize = true;
            this.lDoctorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDoctorInfo.Location = new System.Drawing.Point(257, 58);
            this.lDoctorInfo.Name = "lDoctorInfo";
            this.lDoctorInfo.Size = new System.Drawing.Size(44, 25);
            this.lDoctorInfo.TabIndex = 8;
            this.lDoctorInfo.Text = "Info";
            // 
            // lWarning
            // 
            this.lWarning.AutoSize = true;
            this.lWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWarning.Location = new System.Drawing.Point(365, 383);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(199, 50);
            this.lWarning.TabIndex = 9;
            this.lWarning.Text = "Choose both \r\na patient and a doctor";
            // 
            // tbVisitDescription
            // 
            this.tbVisitDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVisitDescription.Location = new System.Drawing.Point(360, 333);
            this.tbVisitDescription.Name = "tbVisitDescription";
            this.tbVisitDescription.Size = new System.Drawing.Size(204, 30);
            this.tbVisitDescription.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(194, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Visit Description";
            // 
            // tbPatientLookUp
            // 
            this.tbPatientLookUp.Location = new System.Drawing.Point(41, 214);
            this.tbPatientLookUp.Name = "tbPatientLookUp";
            this.tbPatientLookUp.Size = new System.Drawing.Size(141, 22);
            this.tbPatientLookUp.TabIndex = 12;
            this.tbPatientLookUp.TextChanged += new System.EventHandler(this.tbPatientLookUp_TextChanged);
            // 
            // tbDoctorLookUp
            // 
            this.tbDoctorLookUp.Location = new System.Drawing.Point(41, 52);
            this.tbDoctorLookUp.Name = "tbDoctorLookUp";
            this.tbDoctorLookUp.Size = new System.Drawing.Size(141, 22);
            this.tbDoctorLookUp.TabIndex = 13;
            this.tbDoctorLookUp.TextChanged += new System.EventHandler(this.tbDoctorLookUp_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(609, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30"});
            this.cbTime.Location = new System.Drawing.Point(609, 352);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(106, 24);
            this.cbTime.TabIndex = 16;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(605, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date and Time: ";
            // 
            // SetupVisitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbDoctorLookUp);
            this.Controls.Add(this.tbPatientLookUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVisitDescription);
            this.Controls.Add(this.lWarning);
            this.Controls.Add(this.lDoctorInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lPatientInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lChoosePatient);
            this.Controls.Add(this.lbDoctor);
            this.Controls.Add(this.lbPatients);
            this.Controls.Add(this.bSetupVisit);
            this.Name = "SetupVisitScreen";
            this.Text = "SetupVisitScreen";
            this.Load += new System.EventHandler(this.SetupVisitScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSetupVisit;
        private System.Windows.Forms.ListBox lbPatients;
        private System.Windows.Forms.ListBox lbDoctor;
        private System.Windows.Forms.Label lChoosePatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lPatientInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lDoctorInfo;
        private System.Windows.Forms.Label lWarning;
        private System.Windows.Forms.TextBox tbVisitDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPatientLookUp;
        private System.Windows.Forms.TextBox tbDoctorLookUp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label label5;
    }
}

namespace WindowsFormsApp1
{
    partial class VisitScreen
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
            this.bConfirm = new System.Windows.Forms.Button();
            this.tbVisitDescr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lVisitID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDiagnosis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linfo = new System.Windows.Forms.Label();
            this.lDoctorInfo = new System.Windows.Forms.Label();
            this.lPatientInfo = new System.Windows.Forms.Label();
            this.lReceptionistInfo = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lconfirmation = new System.Windows.Forms.Label();
            this.bCancell = new System.Windows.Forms.Button();
            this.bFinish = new System.Windows.Forms.Button();
            this.lVisitStatus = new System.Windows.Forms.Label();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.bSetUpExam = new System.Windows.Forms.Button();
            this.tbExamResoult = new System.Windows.Forms.TextBox();
            this.lResoult = new System.Windows.Forms.Label();
            this.bExamConfirm = new System.Windows.Forms.Button();
            this.cbExamType = new System.Windows.Forms.ComboBox();
            this.lExamType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // bConfirm
            // 
            this.bConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bConfirm.Location = new System.Drawing.Point(57, 319);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(151, 45);
            this.bConfirm.TabIndex = 0;
            this.bConfirm.Text = "Save changes";
            this.bConfirm.UseVisualStyleBackColor = false;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // tbVisitDescr
            // 
            this.tbVisitDescr.Location = new System.Drawing.Point(164, 230);
            this.tbVisitDescr.Name = "tbVisitDescr";
            this.tbVisitDescr.Size = new System.Drawing.Size(280, 22);
            this.tbVisitDescr.TabIndex = 4;
            this.tbVisitDescr.TextChanged += new System.EventHandler(this.tbVisitDescr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(59, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Docor Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Receptionist Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Visit Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Visit ID:";
            // 
            // lVisitID
            // 
            this.lVisitID.AutoSize = true;
            this.lVisitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lVisitID.Location = new System.Drawing.Point(89, 12);
            this.lVisitID.Name = "lVisitID";
            this.lVisitID.Size = new System.Drawing.Size(64, 20);
            this.lVisitID.TabIndex = 10;
            this.lVisitID.Text = "Visit ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(222, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Visit Status:";
            // 
            // tbDiagnosis
            // 
            this.tbDiagnosis.Location = new System.Drawing.Point(164, 270);
            this.tbDiagnosis.Name = "tbDiagnosis";
            this.tbDiagnosis.Size = new System.Drawing.Size(280, 22);
            this.tbDiagnosis.TabIndex = 13;
            this.tbDiagnosis.TextChanged += new System.EventHandler(this.tbDiagnosis_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(55, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Diagnosis";
            // 
            // linfo
            // 
            this.linfo.AutoSize = true;
            this.linfo.Location = new System.Drawing.Point(344, 64);
            this.linfo.Name = "linfo";
            this.linfo.Size = new System.Drawing.Size(46, 17);
            this.linfo.TabIndex = 15;
            this.linfo.Text = "label8";
            // 
            // lDoctorInfo
            // 
            this.lDoctorInfo.AutoSize = true;
            this.lDoctorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDoctorInfo.Location = new System.Drawing.Point(160, 91);
            this.lDoctorInfo.Name = "lDoctorInfo";
            this.lDoctorInfo.Size = new System.Drawing.Size(137, 20);
            this.lDoctorInfo.TabIndex = 16;
            this.lDoctorInfo.Text = "DoctorLastName";
            this.lDoctorInfo.Click += new System.EventHandler(this.lDoctorLastName_Click);
            // 
            // lPatientInfo
            // 
            this.lPatientInfo.AutoSize = true;
            this.lPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPatientInfo.Location = new System.Drawing.Point(160, 126);
            this.lPatientInfo.Name = "lPatientInfo";
            this.lPatientInfo.Size = new System.Drawing.Size(138, 20);
            this.lPatientInfo.TabIndex = 17;
            this.lPatientInfo.Text = "PatientLastName";
            this.lPatientInfo.Click += new System.EventHandler(this.lPatientName_Click);
            // 
            // lReceptionistInfo
            // 
            this.lReceptionistInfo.AutoSize = true;
            this.lReceptionistInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lReceptionistInfo.Location = new System.Drawing.Point(160, 163);
            this.lReceptionistInfo.Name = "lReceptionistInfo";
            this.lReceptionistInfo.Size = new System.Drawing.Size(179, 20);
            this.lReceptionistInfo.TabIndex = 18;
            this.lReceptionistInfo.Text = "ReceptionistLastName";
            this.lReceptionistInfo.Click += new System.EventHandler(this.lReceptionistInfo_Click);
            // 
            // lconfirmation
            // 
            this.lconfirmation.AutoSize = true;
            this.lconfirmation.Location = new System.Drawing.Point(344, 393);
            this.lconfirmation.Name = "lconfirmation";
            this.lconfirmation.Size = new System.Drawing.Size(46, 17);
            this.lconfirmation.TabIndex = 19;
            this.lconfirmation.Text = "label8";
            // 
            // bCancell
            // 
            this.bCancell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bCancell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancell.Location = new System.Drawing.Point(54, 388);
            this.bCancell.Name = "bCancell";
            this.bCancell.Size = new System.Drawing.Size(114, 60);
            this.bCancell.TabIndex = 20;
            this.bCancell.Text = "Cancell Visit";
            this.bCancell.UseVisualStyleBackColor = false;
            this.bCancell.Click += new System.EventHandler(this.bCancell_Click);
            // 
            // bFinish
            // 
            this.bFinish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFinish.Location = new System.Drawing.Point(203, 388);
            this.bFinish.Name = "bFinish";
            this.bFinish.Size = new System.Drawing.Size(114, 60);
            this.bFinish.TabIndex = 21;
            this.bFinish.Text = "Finish Visit";
            this.bFinish.UseVisualStyleBackColor = false;
            this.bFinish.Click += new System.EventHandler(this.bFinish_Click);
            // 
            // lVisitStatus
            // 
            this.lVisitStatus.AutoSize = true;
            this.lVisitStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lVisitStatus.Location = new System.Drawing.Point(328, 12);
            this.lVisitStatus.Name = "lVisitStatus";
            this.lVisitStatus.Size = new System.Drawing.Size(95, 20);
            this.lVisitStatus.TabIndex = 22;
            this.lVisitStatus.Text = "Visit Status";
            // 
            // dgvExams
            // 
            this.dgvExams.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Location = new System.Drawing.Point(472, 82);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.RowHeadersWidth = 51;
            this.dgvExams.RowTemplate.Height = 24;
            this.dgvExams.Size = new System.Drawing.Size(297, 186);
            this.dgvExams.TabIndex = 23;
            this.dgvExams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExams_CellContentClick);
            // 
            // bSetUpExam
            // 
            this.bSetUpExam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSetUpExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSetUpExam.Location = new System.Drawing.Point(272, 319);
            this.bSetUpExam.Name = "bSetUpExam";
            this.bSetUpExam.Size = new System.Drawing.Size(118, 45);
            this.bSetUpExam.TabIndex = 24;
            this.bSetUpExam.Text = "New Exam";
            this.bSetUpExam.UseVisualStyleBackColor = false;
            this.bSetUpExam.Click += new System.EventHandler(this.bSetUpExam_Click);
            // 
            // tbExamResoult
            // 
            this.tbExamResoult.Location = new System.Drawing.Point(573, 356);
            this.tbExamResoult.Name = "tbExamResoult";
            this.tbExamResoult.Size = new System.Drawing.Size(180, 22);
            this.tbExamResoult.TabIndex = 25;
            // 
            // lResoult
            // 
            this.lResoult.AutoSize = true;
            this.lResoult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lResoult.Location = new System.Drawing.Point(468, 358);
            this.lResoult.Name = "lResoult";
            this.lResoult.Size = new System.Drawing.Size(66, 20);
            this.lResoult.TabIndex = 26;
            this.lResoult.Text = "Resoult";
            // 
            // bExamConfirm
            // 
            this.bExamConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bExamConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bExamConfirm.Location = new System.Drawing.Point(573, 398);
            this.bExamConfirm.Name = "bExamConfirm";
            this.bExamConfirm.Size = new System.Drawing.Size(114, 45);
            this.bExamConfirm.TabIndex = 27;
            this.bExamConfirm.Text = "Confirm";
            this.bExamConfirm.UseVisualStyleBackColor = false;
            this.bExamConfirm.Click += new System.EventHandler(this.bExamConfirm_Click);
            // 
            // cbExamType
            // 
            this.cbExamType.FormattingEnabled = true;
            this.cbExamType.Location = new System.Drawing.Point(573, 305);
            this.cbExamType.Name = "cbExamType";
            this.cbExamType.Size = new System.Drawing.Size(180, 24);
            this.cbExamType.TabIndex = 28;
            this.cbExamType.SelectedIndexChanged += new System.EventHandler(this.cbExamType_SelectedIndexChanged);
            // 
            // lExamType
            // 
            this.lExamType.AutoSize = true;
            this.lExamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lExamType.Location = new System.Drawing.Point(468, 305);
            this.lExamType.Name = "lExamType";
            this.lExamType.Size = new System.Drawing.Size(87, 20);
            this.lExamType.TabIndex = 29;
            this.lExamType.Text = "Exam type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(467, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Exams:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(468, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Date:";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lDate.Location = new System.Drawing.Point(524, 12);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(85, 20);
            this.lDate.TabIndex = 32;
            this.lDate.Text = "xx-xx-xxxx";
            // 
            // VisitScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lExamType);
            this.Controls.Add(this.cbExamType);
            this.Controls.Add(this.bExamConfirm);
            this.Controls.Add(this.lResoult);
            this.Controls.Add(this.tbExamResoult);
            this.Controls.Add(this.bSetUpExam);
            this.Controls.Add(this.dgvExams);
            this.Controls.Add(this.lVisitStatus);
            this.Controls.Add(this.bFinish);
            this.Controls.Add(this.bCancell);
            this.Controls.Add(this.lconfirmation);
            this.Controls.Add(this.lReceptionistInfo);
            this.Controls.Add(this.lPatientInfo);
            this.Controls.Add(this.lDoctorInfo);
            this.Controls.Add(this.linfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDiagnosis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lVisitID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVisitDescr);
            this.Controls.Add(this.bConfirm);
            this.Name = "VisitScreen";
            this.Text = "VisitScreen";
            this.Load += new System.EventHandler(this.VisitScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.TextBox tbVisitDescr;
        protected internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        protected internal System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.Label lVisitID;
        protected internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDiagnosis;
        protected internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label linfo;
        protected internal System.Windows.Forms.Label lDoctorInfo;
        protected internal System.Windows.Forms.Label lPatientInfo;
        protected internal System.Windows.Forms.Label lReceptionistInfo;
        private System.Windows.Forms.Label lconfirmation;
        private System.Windows.Forms.Button bCancell;
        private System.Windows.Forms.Button bFinish;
        protected internal System.Windows.Forms.Label lVisitStatus;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Button bSetUpExam;
        private System.Windows.Forms.TextBox tbExamResoult;
        protected internal System.Windows.Forms.Label lResoult;
        private System.Windows.Forms.Button bExamConfirm;
        private System.Windows.Forms.ComboBox cbExamType;
        protected internal System.Windows.Forms.Label lExamType;
        private System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.Label lDate;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VisitScreen : Form
    {
        BindingSource myBindingSource = new BindingSource();
        Visit visit;

        bool examTypeSelected = false;
        string code;

        public VisitScreen()
        {
            InitializeComponent();
        }
        public VisitScreen(int visitID)
        {
            DAO myDAO = new DAO();
            myBindingSource.DataSource = myDAO.FindVisit(visitID);
            InitializeComponent();
            this.visit =myDAO.FindVisit(visitID);
        }

        private void VisitScreen_Load(object sender, EventArgs e)
        {
            linfo.Hide();
            lconfirmation.Hide();

            lVisitID.Text = visit.visitID.ToString();
            lVisitStatus.Text = visit.visitStatus;
            lPatientInfo.Text = visit.patientID.lastName + " " + visit.patientID.firstName;
            lDoctorInfo.Text = visit.doctorID.lastName + " " + visit.doctorID.firstName;
            lReceptionistInfo.Text = visit.receptionistID.lastName + " " + visit.receptionistID.firstName;

            SetTextBoxes();
            List<ExamDictionary> examType = new List<ExamDictionary>();
            DAO myDAO = new DAO();
            myBindingSource.DataSource = myDAO.GetExamDictionaries();
            examType = myDAO.GetExamDictionaries();

            string s;
            foreach (ExamDictionary exam in examType)
            {
                s = exam.examCode + " " + exam.examDescription;
                cbExamType.Items.Add(s);
            }

            loadDataBase();
            hideExam();

            dgvExams.AllowUserToAddRows = false;
            dgvExams.AllowUserToDeleteRows = false;
            dgvExams.ReadOnly = true;

            if (visit.visitStatus == "COMPLITED" || visit.visitStatus == "CANCELLED")
            {

                tbDiagnosis.Enabled = false;
                tbVisitDescr.Enabled = false;

                bCancell.Hide();
                bConfirm.Hide();
                bFinish.Hide();
                bSetUpExam.Hide();
            }

        }
        private void bConfirm_Click(object sender, EventArgs e)
        {
            DAO myDAO = new DAO();
          
            myDAO.UpdateVisit(visit.visitID, tbVisitDescr.Text,visit.visitStatus ,tbDiagnosis.Text);

            lconfirmation.Text = "Visit information changed";
            lconfirmation.Show();
        }

        private void lDoctorLastName_Click(object sender, EventArgs e)
        {
            lconfirmation.Hide();

            linfo.Show();
            linfo.Text = "Last Name: \n"+visit.doctorID.lastName+"\nFirst Name:\n"+visit.doctorID.firstName+
                "\nSex: "+visit.doctorID.sex+"\nNPWZ number: \n"+visit.doctorID.npwzID+"\nEmployee ID:\n"+visit.doctorID.employeeID;
        }

        private void lPatientName_Click(object sender, EventArgs e)
        {
            lconfirmation.Hide();

            linfo.Show();
            linfo.Text = "Last Name: \n" + visit.patientID.lastName + "\nFirst Name:\n" + visit.patientID.firstName +
                "\nSex: " + visit.patientID.sex + "\nInsurance number: \n" + visit.patientID.insuranceID ;
        }

        private void lReceptionistInfo_Click(object sender, EventArgs e)
        {
            lconfirmation.Hide();

            linfo.Show();
            if (visit.receptionistID != null)
            {
                linfo.Text = "Last Name: \n" + visit.receptionistID.lastName + "\nFirst Name:\n" + visit.receptionistID.firstName +
                    "\nSex: " + visit.receptionistID.sex + "\nEmployee ID:\n" + visit.receptionistID.employeeID;
            }
            else
            {
                linfo.Text = "Not registered by a receptionist";
            }
        }

        private void SetTextBoxes()
        {
            tbDiagnosis.Text = visit.diagnosis;
            tbVisitDescr.Text = visit.description;
         
        }

        private void tbVisitDescr_TextChanged(object sender, EventArgs e)
        {
            lconfirmation.Hide();

        }

        private void tbVisitStatus_TextChanged(object sender, EventArgs e)
        {
            lconfirmation.Hide();

        }

        private void tbDiagnosis_TextChanged(object sender, EventArgs e)
        {
            lconfirmation.Hide();

        }

        private void bCancell_Click(object sender, EventArgs e)
        {
            DAO myDAO = new DAO();

            myDAO.UpdateVisit(visit.visitID, tbVisitDescr.Text, "CANCELLED", tbDiagnosis.Text);

            lconfirmation.Text = "Visit cancelled";
            lconfirmation.Show();
        }

        private void bFinish_Click(object sender, EventArgs e)
        {
            DAO myDAO = new DAO();

            myDAO.UpdateVisit(visit.visitID, tbVisitDescr.Text, "COMPLITED", tbDiagnosis.Text);

            lconfirmation.Text = "Visit Complited";
            lconfirmation.Show();
        }

        private void cbExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAO myDao = new DAO();
            List<ExamDictionary> dictionaries = myDao.GetExamDictionaries();
            examTypeSelected = true;
            int i = cbExamType.SelectedIndex;
            code = dictionaries[i].examCode;
        }

        private void bExamConfirm_Click(object sender, EventArgs e)
        {
            if (tbExamResoult.Text != "" && examTypeSelected)
            {
                examTypeSelected = false;
                DAO myDao = new DAO();

                myDao.AddExam(tbExamResoult.Text, visit.visitID, code);
                loadDataBase();
            }
            else
            {
                lconfirmation.Text = "Choose exam type \nand fill in exam resoult";
                lconfirmation.Show();
            }
        }

        private void loadDataBase()
        {
            DAO myDao = new DAO();
            dgvExams.DataSource = myDao.GetExamsData(visit.visitID);

        }

        private void hideExam()
        {
            tbExamResoult.Text = "";
            cbExamType.SelectedIndex = -1;

            tbExamResoult.Hide();
            lResoult.Hide();
            lExamType.Hide();
            cbExamType.Hide();
            bExamConfirm.Hide();

        }

        private void showExam()
        {
            tbExamResoult.Show();
            lResoult.Show();
            lExamType.Show();
            cbExamType.Show();
            bExamConfirm.Show();
            
        }

        private void bSetUpExam_Click(object sender, EventArgs e)
        {
            hideExam();
            showExam();
        }

        private void dgvExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         //   int i = dgvExams.SelectedCells.Count;

          //  linfo.Text = i + "";
          //  linfo.Show();
        } 
    }
}

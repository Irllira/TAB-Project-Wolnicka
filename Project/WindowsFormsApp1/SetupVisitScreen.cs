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
    public partial class SetupVisitScreen : Form
    {
        BindingSource myBindingSource = new BindingSource();

        BindingSource doctorBindingSource = new BindingSource();
        BindingSource patientBindingSource = new BindingSource();

 //       Doctor doctor;

        int patientID = -1;
        int doctorID = -1;
        int receptionistID;

        DateTime dateTime;
        bool isTimeSet = false;

        List <Patient> patients = new List<Patient>();
        List<Doctor> doctors = new List<Doctor>();

        public SetupVisitScreen(int i)
        {
            InitializeComponent();
            receptionistID = i;
        }

        private void SetupVisitScreen_Load(object sender, EventArgs e)
        {
            lWarning.Hide();

            FindPatients("");
            FindDoctors("");


            SetTime();

            lPatientInfo.Text = " ";

            lDoctorInfo.Text = " ";

        }

        private void lbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lWarning.Hide();

            if (lbPatients.SelectedItem == null)
                return;

            patientID = lbPatients.SelectedIndex;
          
            Patient patient =patients[patientID];

        
            lPatientInfo.Text = "Last Name: \n" + patient.lastName + "\nFirst Name:\n" + patient.firstName +
                    "\nSex: " + patient.sex + "\nInsurance ID:\n" + patient.insuranceID;
        }

        private void lbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lWarning.Hide();

            if (lbDoctor.SelectedItem == null)
                return;

            doctorID = lbDoctor.SelectedIndex;
            Doctor doctor = doctors[doctorID];

            lDoctorInfo.Text = "Last Name: \n" + doctor.lastName + "\nFirst Name:\n" + doctor.firstName +
                    "\nSex: " + doctor.sex + "\nNPWZ number: \n" + doctor.npwzID + "\nEmployee ID:\n" + doctor.employeeID;
        }

        private void bSetupVisit_Click(object sender, EventArgs e)
        {
            if (patientID == -1 || doctorID == -1)
            {

                lWarning.Text = "Choose both \na doctor an a patient";

                lWarning.Show();

                return;
            }

            if (tbVisitDescription.Text == "")
            {
                lWarning.Text = "Fill the visit description";
                lWarning.Show();
                return;
            }

            if (!isTimeSet)
            {
                lWarning.Text = "Choose visit date and time";
                lWarning.Show();
                return;
            }
            else
            {
                DAO myDAO = new DAO();
                myDAO.AddVisit(patients[patientID].patientID, doctors[doctorID].employeeID, receptionistID, tbVisitDescription.Text,dateTime);
                lWarning.Text = "Visit was successfully set up";
                lWarning.Show();
            }


        }

        private void tbDoctorLookUp_TextChanged(object sender, EventArgs e)
        {
            FindDoctors(tbDoctorLookUp.Text);
        }

        private void tbPatientLookUp_TextChanged(object sender, EventArgs e)
        {
            FindPatients(tbPatientLookUp.Text);
        }

        private void FindPatients(string name)
        {
            lbPatients.Items.Clear();
            patients.Clear();

            DAO myDAO2 = new DAO();
            patientBindingSource.DataSource = myDAO2.GetPatients();
            patients = myDAO2.GetPatients();
            string s;

            foreach (Patient p in patients)
            {
                if (p.lastName.Contains(name) || name == "")
                {
                    s = p.patientID.ToString() + "   " + p.lastName;
                    lbPatients.Items.Add(s);
                }
            }
        }

        private void FindDoctors(string name)
        {
            lbDoctor.Items.Clear();
            doctors.Clear();

            DAO myDAO = new DAO();
            doctorBindingSource.DataSource = myDAO.GetDoctors();
            doctors = myDAO.GetDoctors();
            string s;
            foreach (Doctor d in doctors)
            {
                if (d.lastName.Contains(name) || name == "")
                {
                    s = d.employeeID.ToString() + "   " + d.lastName;
                    lbDoctor.Items.Add(s);
                }
            }
        }

        private void SetTime()
        {
            cbTime.Items.Clear();
            for(int i=8; i<=18; i++)
            {
                cbTime.Items.Add(i + ":00");
                cbTime.Items.Add(i + ":30");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            isTimeSet = false;

            lWarning.Text = "";
            lWarning.Hide();

            DateTime now = DateTime.Now;
            if(dateTimePicker1.Value<now)
            {
                lWarning.Text ="The date picked is in the past";
                lWarning.Show();
            }

            if (cbTime.SelectedIndex != -1)
            {
                CheckVisitTime();

            }
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTimeSet = false;
            lWarning.Text = "";
            lWarning.Hide();


            CheckVisitTime();
        }


        private void CheckVisitTime()
        {
            DateTime now = DateTime.Now;
            DateTime date = dateTimePicker1.Value;

            string buff = date.Year + "-" + date.Month + "-" + date.Day + " " + cbTime.SelectedItem.ToString();

            DateTime time = DateTime.Parse(buff);

            if (time < now)
            {
                lWarning.Text = "The date picked is in the past";
                lWarning.Show();
                return;
            }
            DAO myDAO = new DAO();
            if (myDAO.FindVisitByTime(doctorID, time))
            {
                lWarning.Text = "The date picked is \nalredy taken for this doctor";
                lWarning.Show();
                return;
            }
            dateTime = time;
            isTimeSet = true;
        }
    }
}

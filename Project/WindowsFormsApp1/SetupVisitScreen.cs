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
        
        List<Patient> patients = new List<Patient>();
        List<Doctor> doctors = new List<Doctor>();

        public SetupVisitScreen(int i)
        {
            InitializeComponent();
            receptionistID = i;
        }

        private void SetupVisitScreen_Load(object sender, EventArgs e)
        {
            lWarning.Hide();

           
            DAO myDAO = new DAO();
            doctorBindingSource.DataSource = myDAO.GetDoctors();
            doctors = myDAO.GetDoctors();
            string s;
            foreach (Doctor d in doctors)
            {
                s = d.employeeID.ToString()+ "   "+ d.lastName;
                lbDoctor.Items.Add(s);
            }
          
            DAO myDAO2 = new DAO();
            patientBindingSource.DataSource = myDAO2.GetPatients();
            patients = myDAO2.GetPatients();
            foreach (Patient p in patients)
            {
                s = p.patientID.ToString()+ "   "+ p.lastName;
                lbPatients.Items.Add(s);
            }

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
            }
            else
            {
                if (tbVisitDescription.Text == "")
                {
                    lWarning.Text = "Fill the visit description";
                    lWarning.Show();
                }
                else
                {
                    DAO myDAO = new DAO();
                    myDAO.AddVisit(patients[patientID].patientID, doctors[doctorID].employeeID, receptionistID, tbVisitDescription.Text);
                    lWarning.Text = "Visit was successfully set up";
                    lWarning.Show();
                }
            }
        }
    }
}

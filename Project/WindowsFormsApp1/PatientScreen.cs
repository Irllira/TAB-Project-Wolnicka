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
    public partial class PatientScreen : Form
    {
        int patientID=1;
        public PatientScreen()
        {
            InitializeComponent();
        }

        private void bPersonalData_Click(object sender, EventArgs e)
        {
            pPanel.Controls.Clear();

            PersonalDataScreen visitForm = new PersonalDataScreen("Patient", patientID) { TopLevel = false, TopMost = true };

            visitForm.FormBorderStyle = FormBorderStyle.None;
            pPanel.Controls.Add(visitForm);
            visitForm.Show();
            pPanel.Show();
        }

        private void bNewVisit_Click(object sender, EventArgs e)
        {
            pPanel.Controls.Clear();

            SetupVisitScreen setupvisitForm = new SetupVisitScreen(patientID) { TopLevel = false, TopMost = true };

            setupvisitForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
            pPanel.Controls.Add(setupvisitForm);
            setupvisitForm.Show();
            pPanel.Show();
        }
    }
}

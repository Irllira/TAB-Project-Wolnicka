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
    public partial class ReceptonistScreen : Form
    {
        int receptionistID;
        public ReceptonistScreen(int i)
        {
            InitializeComponent();
            receptionistID = i;
        }

        private void bPersonalData_Click(object sender, EventArgs e)
        {
            pPanel.Controls.Clear();

            PersonalDataScreen visitForm = new PersonalDataScreen("Receptionist", receptionistID) { TopLevel = false, TopMost = true };

            visitForm.FormBorderStyle = FormBorderStyle.None;
            pPanel.Controls.Add(visitForm);
            visitForm.Show();
            pPanel.Show();
        }

        private void bNewVisit_Click(object sender, EventArgs e)
        {
            pPanel.Controls.Clear();

            SetupVisitScreen setupvisitForm = new SetupVisitScreen(receptionistID) { TopLevel = false, TopMost = true };

            setupvisitForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
            pPanel.Controls.Add(setupvisitForm);
            setupvisitForm.Show();
            pPanel.Show();
        }

        private void bPatient_Click(object sender, EventArgs e)
        {
            pPanel.Controls.Clear();

            NewPatientScreen setupvisitForm = new NewPatientScreen() { TopLevel = false, TopMost = true };

            setupvisitForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
            pPanel.Controls.Add(setupvisitForm);
            setupvisitForm.Show();
            pPanel.Show();
        }

        private void ReceptonistScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

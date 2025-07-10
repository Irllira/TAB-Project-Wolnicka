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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            LoginScreen logForm = new LoginScreen() { TopLevel = false, TopMost = true };

            logForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
            pPanel.Controls.Add(logForm);
            logForm.Show();
            pPanel.Show();
            HideAllButtons();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pPanel.Hide();
        }

        private void bNewUser_Click(object sender, EventArgs e)
        {
            NewUserScreen newUserForm = new NewUserScreen() { TopLevel = false, TopMost = true };

            newUserForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
            pPanel.Controls.Add(newUserForm);
            newUserForm.Show();
           
            pPanel.Show();
            HideAllButtons();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pPanel.Hide();
            bLogIn.Show();
            bNewUser.Show();
            bDoctor.Show();
            bSecretary.Show();
            bPatient.Show();

            pPanel.Controls.RemoveAt(1);
        }

        private void bDoctor_Click(object sender, EventArgs e)
        {
            DoctorScreen doctorForm = new DoctorScreen(23) { TopLevel = false, TopMost = true };

            doctorForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
            pPanel.Controls.Add(doctorForm);
            doctorForm.Show();
            pPanel.Show();
            HideAllButtons();

        }

        private void bPatient_Click(object sender, EventArgs e)
        {
            PatientScreen patientForm = new PatientScreen() { TopLevel = false, TopMost = true };

            patientForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
            pPanel.Controls.Add(patientForm);
            patientForm.Show();
            pPanel.Show();
            HideAllButtons();
        }


        private void HideAllButtons()
        {
            bLogIn.Hide();
            bNewUser.Hide();
            bDoctor.Hide();
            bPatient.Hide();
            bSecretary.Hide();
        }

        private void bSecretary_Click(object sender, EventArgs e)
        {
            ReceptonistScreen setupvisitForm = new ReceptonistScreen(19) { TopLevel = false, TopMost = true };

            setupvisitForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
            pPanel.Controls.Add(setupvisitForm);
            setupvisitForm.Show();
            pPanel.Show();
            HideAllButtons();
        }
    }
}

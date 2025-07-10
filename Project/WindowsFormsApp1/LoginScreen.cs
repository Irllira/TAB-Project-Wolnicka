using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" || tbPassword.Text == "")
            {
                lIncorrect.Show();
                return;
            }

            DAO myDao = new DAO();
            User u = myDao.FindUser(tbLogin.Text);

            if (u.passwordName != tbPassword.Text)
            {
                lIncorrect.Show();

                lIncorrect.Text = "Incorrect username or password";

                return;
            }
            Thread.Sleep(1000);
            lIncorrect.Show();
            switch (u.role)
            {
                case "DOCTOR     ":
                    lIncorrect.Text = "Login succesfull";
                    callDoctor(u.staffID);

                    break;
                case "RECEPT     ":
                    lIncorrect.Text = "Login succesfull";
                    callReceptionist(u.staffID);
                    break;
                case "ADMIN      ":
                    lIncorrect.Text = "Login succesfull";
                    callAdmin();
                    break;
            }



        }

        private void callAdmin()
        {
            AdminScreen adminForm = new AdminScreen() { TopLevel = false, TopMost = true };

            adminForm.FormBorderStyle = FormBorderStyle.None;

            pPanel.Controls.Add(adminForm);
            adminForm.Show();
            pPanel.Show();
            HideAll();
        }


        private void callDoctor(int doctorID)
        {
            DoctorScreen doctorForm = new DoctorScreen(doctorID) { TopLevel = false, TopMost = true };

            doctorForm.FormBorderStyle = FormBorderStyle.None;

            pPanel.Controls.Add(doctorForm);
            doctorForm.Show();
            pPanel.Show();
            HideAll();
        }

        private void callReceptionist(int receptID)
        {
            ReceptonistScreen receptonistForm = new ReceptonistScreen(receptID) { TopLevel = false, TopMost = true };

            receptonistForm.FormBorderStyle = FormBorderStyle.None;
            pPanel.Controls.Add(receptonistForm);
            receptonistForm.Show();
            pPanel.Show();
            HideAll();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            lIncorrect.Hide();
            pPanel.Hide();
        }

        private void HideAll()
        {
            bLogin.Hide();
            lIncorrect.Hide();
            lLogin.Hide();
            lPassword.Hide();
            tbLogin.Hide();
            tbPassword.Hide();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            pPanel.Controls.RemoveAt(1);

            pPanel.Hide();
            bLogin.Show();
            lIncorrect.Show();
            lLogin.Show();
            lPassword.Show();
            tbLogin.Show();
            tbPassword.Show();
        }
    }
}

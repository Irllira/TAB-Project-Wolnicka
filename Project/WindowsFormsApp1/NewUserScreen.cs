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
    public partial class NewUserScreen : Form
    {
        string type="";
        public NewUserScreen()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbConfPass.Text != tbPassword.Text)
            {
                lWarning.Text = "The passwords \nneed to be the same";
                lWarning.Show();
                return;
            }
            if (tbPassword.Text == "" || tbConfPass.Text == "" || tbLogin.Text == "" ||
                tbFirstName.Text == "" || tbLastName.Text == "" || tbSex.Text == "")
            {
                lWarning.Text = "All the data needs to be filled";
                lWarning.Show();
                return;
            }
            if(type=="")
            {
                lWarning.Text = "Choose the type of \naccount you want to create";
                lWarning.Show();
                return;
            }


            DAO myDAO = new DAO();
            int i;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    myDAO.AddDoctor(tbFirstName.Text,tbLastName.Text,tbSex.Text[0],tbNationalID.Text,tbNPWZ.Text);
                    i = myDAO.FindDoctorID();
                    myDAO.AddUser(tbLogin.Text, tbPassword.Text, "DOCTOR",i);
                    break;
                case 1:
                    myDAO.AddReceptionist(tbFirstName.Text, tbLastName.Text, tbSex.Text[0], tbNationalID.Text);
                    i = myDAO.FindReceptionistID();
                    myDAO.AddUser(tbLogin.Text, tbPassword.Text, "RECEPT", i);
                    break;
                case 2:
                    myDAO.AddUser(tbLogin.Text, tbPassword.Text, "ADMIN");
                    break;
            }
            lWarning.Text = "User added succesfully";
            lWarning.Show();
        }
        private void NewUser_Load(object sender, EventArgs e)
        {
            lWarning.Hide();
            HideInfo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideInfo();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    type = "doctor";
                    ShowBasicInfo();
                    lNPWZ.Show();
                    tbNPWZ.Show();
                    break;
                case 1:
                    type = "receptionist";
                    ShowBasicInfo();
                    break;
                case 2:
                    type = "admin";
                    break;
            }
        }

        private void HideInfo()
        {
            lFirstName.Hide();
            lLastName.Hide();
            lNationalID.Hide();
            lNPWZ.Hide();
            lSex.Hide();

            tbFirstName.Hide();
            tbLastName.Hide();
            tbSex.Hide();
            tbNationalID.Hide();
            tbNPWZ.Hide();
        }

        private void ShowBasicInfo()
        {
            lFirstName.Show();
            lLastName.Show();
            lNationalID.Show();
            lSex.Show();

            tbFirstName.Show();
            tbLastName.Show();
            tbSex.Show();
            tbNationalID.Show();
        }
    }
}

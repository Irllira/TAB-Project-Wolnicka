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
    public partial class NewPatientScreen : Form
    {
        public NewPatientScreen()
        {
            InitializeComponent();
            lWarning.Hide();
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text ==""|| tbLastName.Text == "" || tbSex.Text == "" || tbNationalID.Text == "" || tbInsurance.Text == "")
            {
                lWarning.Text = "Fill all the nessesary information";
                lWarning.Show();
            }
            else
            {
                DAO myDAO = new DAO();
                myDAO.AddPatient(tbFirstName.Text, tbLastName.Text, tbSex.Text[0], tbNationalID.Text, tbInsurance.Text);
                lWarning.Text = "The patient added succesfully";
                lWarning.Show();
            }
        }
    }
}

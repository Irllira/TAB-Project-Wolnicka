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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void bNewUser_Click(object sender, EventArgs e)
        {

            pPanel.Controls.Clear();

            NewUserScreen newUserForm = new NewUserScreen() { TopLevel = false, TopMost = true };

            newUserForm.FormBorderStyle = FormBorderStyle.None;
            pPanel.Controls.Add(newUserForm);
            newUserForm.Show();
            pPanel.Show();

        }

        private void bDeactivate_Click(object sender, EventArgs e)
        {
            pPanel.Controls.Clear();

            DeactivateUserScreen deactivateUserForm = new DeactivateUserScreen() { TopLevel = false, TopMost = true };

            deactivateUserForm.FormBorderStyle = FormBorderStyle.None;
            pPanel.Controls.Add(deactivateUserForm);
            deactivateUserForm.Show();
            pPanel.Show();

        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            bDeactivate.Hide();
        }
    }
}

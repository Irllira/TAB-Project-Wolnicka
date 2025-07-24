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
    public partial class DeactivateUserScreen : Form
    {
        string userName="";
        bool activate = false;
        public DeactivateUserScreen()
        {
            InitializeComponent();
        }
     

        private void DeactivateUserScreen_Load(object sender, EventArgs e)
        {
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.SelectionMode = 0;

            lSelectedUser.Text = "";
            lMessage.Text = "";
            lMessage.Hide();

            DAO myDao = new DAO();
            dgvUsers.DataSource = myDao.GetUserData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lMessage.Hide();
            int rowIndex = dgvUsers.SelectedCells[0].RowIndex;
            userName = dgvUsers[0, rowIndex].Value.ToString();
            lSelectedUser.Text = userName;
            DAO myDao = new DAO();
            if (myDao.FindUser(userName).active != '0')
            {
                bDeactivate.Text = "Deactivate User";
                activate = false;
            } else
            {
                bDeactivate.Text = "Activate User";
                activate = true;
            }
            User u = myDao.FindUser(userName);

            if (u.salt == "" || u.salt == null)
            {
                Hasher hasher = new Hasher();
                string salt = hasher.CreateSalt(12);
                string password = hasher.HashPassword(u.passwordName, salt);
                dgvUsers.DataSource = myDao.GetUserData();
                myDao.UpdateUserPassword(userName, password, salt);
            }

        }

        private void bDeactivate_Click(object sender, EventArgs e)
        {
            if (userName != "")
            {
                DAO myDao = new DAO();
                myDao.DeactivateUser(userName,activate);
                if (!activate)
                {
                    lMessage.Text = "User " + userName + " deactivated";   
                }else
                {
                    lMessage.Text = "User " + userName + " activated";
                }
                lMessage.Show();
                dgvUsers.DataSource = myDao.GetUserData();
            }

        }
    }
}

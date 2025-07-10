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
    public partial class DoctorScreen : Form
    {
        BindingSource myBindingSource = new BindingSource();
        List<Visit> visits = new List<Visit>();
        string visitType = "";

        int doctorID;
        public DoctorScreen(int i)
        {
            InitializeComponent();
            doctorID = i;
           
        }

        private void bVisit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            visits.Clear();
            DAO myDAO = new DAO();

            myBindingSource.DataSource = myDAO.GetVisitsForDoctor(doctorID);
            List<Visit> v = myDAO.GetVisitsForDoctor(doctorID);
            //visits = myDAO.GetVisitsForDoctor(doctorID);


            if (tbLookUp.Text != ""|| visitType != "")
            {
                string x;
                if (visitType != "")
                {
                    foreach (Visit visit in v)
                    {
                        x = tbLookUp.Text;
                        if ((visit.description.Contains(x) || visit.patientID.lastName.Contains(x)) && visit.visitStatus==visitType)
                        {
                            visits.Add(visit);
                        }
                    }
                }else
                {
                    foreach (Visit visit in v)
                    {
                        x = tbLookUp.Text;
                        if (visit.description.Contains(x) || visit.patientID.lastName.Contains(x)) 
                        {
                            visits.Add(visit);
                        }
                    }
                }
            }
            else
            {
                visits = v;
            }


            string s;
            foreach(Visit visit in visits)
            {
                s = visit.visitID.ToString() + "   " + visit.patientID.lastName + "   " + visit.description;
                listBox1.Items.Add(s);
            }

     //      VisitScreen visitForm = new VisitScreen() { TopLevel = false, TopMost = true };

           //visitForm.FormBorderStyle = FormBorderStyle.None;
            //pLogin.Controls;
         //   pPanel.Controls.Add(visitForm);
           // visitForm.Show();
          //  pPanel.Show();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }

            pPanel.Controls.Clear();
            int i = listBox1.SelectedIndex;

           // string o = +"";

            
            int id = visits[i].visitID;
            VisitScreen visitForm = new VisitScreen(id) { TopLevel = false, TopMost = true };

            visitForm.FormBorderStyle = FormBorderStyle.None;          
            pPanel.Controls.Add(visitForm);
            visitForm.Show();
            pPanel.Show();
        }

        private void bPersonalData_Click(object sender, EventArgs e)
        {
            pPanel.Controls.Clear();

            PersonalDataScreen visitForm = new PersonalDataScreen("Doctor",doctorID) { TopLevel = false, TopMost = true };

            visitForm.FormBorderStyle = FormBorderStyle.None;
            pPanel.Controls.Add(visitForm);
            visitForm.Show();
            pPanel.Show();
        }

        private void DoctorScreen_Load(object sender, EventArgs e)
        {
            //dgvVisits.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    visitType = "";
                    break;
                case 1:
                    visitType = "REGISTERED";
                    break;
                case 2:
                    visitType = "COMPLITED";
                    break;
                case 3:
                    visitType = "CANCELLED";
                    break;
            }
        }
    }
}

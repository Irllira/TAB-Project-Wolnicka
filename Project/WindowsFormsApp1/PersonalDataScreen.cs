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
    public partial class PersonalDataScreen : Form
    {
        BindingSource myBindingSource = new BindingSource();
        

        string type;
        int id;

        public PersonalDataScreen(string t, int i)
        {
            InitializeComponent();
            DAO myDAO = new DAO();

            this.type = t;
            this.id = i;

            lclinicID.Text = id.ToString();

            switch (type)
            {
                case "Patient":
                    Patient patient;

                    myBindingSource.DataSource = myDAO.FindPatient(id);
                    patient = myDAO.FindPatient(id);

                    lAditional.Text = "Insurance: ";
                    tbAditional.Text = patient.insuranceID;

                    tbFirstName.Text = patient.firstName;
                    tbLastName.Text = patient.lastName;
                    tbSex.Text = patient.sex + "";
                    tbNationalID.Text = patient.idNumber;
                

                    break;
                case "Doctor":
                    Doctor doctor;

                    myBindingSource.DataSource = myDAO.FindDoctor(id);
                    doctor = myDAO.FindDoctor(id);

                    lAditional.Text = "NPWZ ID: ";

                    tbAditional.Text = doctor.npwzID;
                    tbFirstName.Text = doctor.firstName;
                    tbLastName.Text = doctor.lastName;
                    tbSex.Text = doctor.sex + "";
                    tbNationalID.Text = doctor.idNumber;

                    break;

                case "Receptionist":
                    Receptionist receptionist;

                    lAditional.Text = "";
                    tbAditional.Hide();

                    myBindingSource.DataSource = myDAO.FindReceptionist(id);
                    receptionist = myDAO.FindReceptionist(id);

                    tbFirstName.Text = receptionist.firstName;
                    tbLastName.Text = receptionist.lastName;
                    tbSex.Text = receptionist.sex + "";
                    tbNationalID.Text = receptionist.idNumber;
                    break;
            }
        }

        private void PersonalDataScreen_Load(object sender, EventArgs e)
        {

        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            DAO myDAO = new DAO();

            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string idNumber = tbNationalID.Text;
            string aditional=tbAditional.Text;
            char sex = tbSex.Text[0];



            switch (type)
            {
                case "Doctor":
                    myDAO.UpdateDoctorData(id, lastName, firstName, sex, idNumber, aditional);
                    break;

                case "Patient":
                    myDAO.UpdatePatientData(id,lastName,firstName,sex,idNumber,aditional);
                    break;

                case "Receptionist":
                    aditional = "";
                    myDAO.UpdateReceptionistData(id, lastName, firstName, sex, idNumber);
                    break;
            }
        }
    }
}

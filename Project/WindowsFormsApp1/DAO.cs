using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DAO
    {
        string ConnectionString = "Data Source=DESKTOP-2HI6019;Initial Catalog=DOCTOR_OFFICE;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";


        public List<Visit> GetVisits()
        {
            List<Visit> v = new List<Visit>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            string comand = "Select VISIT.VISIT_ID, VISIT.VISIT_DESCRIPTION, VISIT.DIAGNOSIS,Visit.VISIT_STATUS," +
                "DOCTOR.LAST_NAME, DOCTOR.FIRST_NAME, DOCTOR.SEX, DOCTOR.NATIONAL_ID_NUMBER, DOCTOR.CLINIC_EMPLOYEE_ID, DOCTOR.NPWZ_ID " +
                //   "PATIENT.LAST_NAME, PATIENT.FIRST_NAME, PATIENT.SEX, PATIENT.NATIONAL_ID_NUMBER, PATIENT.NATIONAL_ID_NUMBER " +
                "From VISIT " +
                "JOIN DOCTOR ON VISIT.DOCTOR_ID = DOCTOR.CLINIC_EMPLOYEE_ID";// +
                                                                             //      "JOIN PATIENT ON VISIT.PATIENT_ID = PATIENT.ID;";
            SqlCommand c1 = new SqlCommand(comand, connection);

            connection.Open();

            using (SqlDataReader reader = c1.ExecuteReader())
            {
                while (reader.Read())
                {
                    Visit vis = new Visit
                    {
                        visitID = reader.GetInt32(0),
                        description = reader.GetString(1),
                        //  diagnosis = reader.GetString(2),
                        ///    visitStatus = reader.GetString(3),
                        // doctorID.npwzID = reader.GetInt32(4),
                        //doctorID = reader.GetInt32(4),
                        //receptionistID = reader.GetInt32(5),
                        //   patientID = reader.GetInt32(6),
                    };

                    Doctor doc = new Doctor
                    {
                        lastName = reader.GetString(4),
                        firstName = reader.GetString(5),
                        sex = reader.GetChar(6),
                        //   idNumber = reader.GetString(7),
                        employeeID = reader.GetInt32(8),
                        npwzID = reader.GetString(9)
                    };

                    vis.doctorID = doc;
                    v.Add(vis);
                }
            }
            connection.Close();
            return v;
        }

        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From Doctor";
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Doctor d = new Doctor();
                    d.employeeID = reader.GetInt32(4);
                    if (!reader.IsDBNull(0))
                    {
                        d.firstName = reader.GetString(0);
                    }

                    if (!reader.IsDBNull(1))
                    {

                        d.lastName = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        d.sex = reader.GetString(2)[0];
                    }
                    if (!reader.IsDBNull(3))
                    {
                        d.idNumber = reader.GetString(3);
                    }
                    if (!reader.IsDBNull(5))
                    {
                        d.npwzID = reader.GetString(5);
                    }

                    doctors.Add(d);
                }
            }
            connection.Close();
            return doctors;
        }
        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From Patient";
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Patient p = new Patient();
                    p.patientID = reader.GetInt32(5);
                    if (!reader.IsDBNull(0))
                    {
                        p.firstName = reader.GetString(0);
                    }

                    if (!reader.IsDBNull(1))
                    {

                        p.lastName = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        p.sex = reader.GetString(2)[0];
                    }
                    if (!reader.IsDBNull(3))
                    {
                        p.idNumber = reader.GetString(3);
                    }
                    if (!reader.IsDBNull(4))
                    {
                        p.insuranceID = reader.GetString(4);
                    }

                    patients.Add(p);
                }
            }
            connection.Close();
            return patients;
        }

        public List<Receptionist> GetReceptionists()
        {
            List<Receptionist> receptionists = new List<Receptionist>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From RECEPTIONIST";
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Receptionist r = new Receptionist();
                    r.employeeID = reader.GetInt32(4);
                    if (!reader.IsDBNull(0))
                    {
                        r.firstName = reader.GetString(0);
                    }

                    if (!reader.IsDBNull(1))
                    {

                        r.lastName = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        r.sex = reader.GetString(2)[0];
                    }
                    if (!reader.IsDBNull(3))
                    {
                        r.idNumber = reader.GetString(3);
                    }

                    receptionists.Add(r);
                }
            }
            connection.Close();
            return receptionists;
        }
        public List<Visit> GetVisitsForDoctor(int doctorID)
        {
            List<Visit> v = new List<Visit>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From VISIT where DOCTOR_ID = @doctorID";
            command.Parameters.AddWithValue("@doctorID", doctorID);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Visit vis = new Visit();
                    vis.visitID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                    {
                        vis.description = reader.GetString(1);
                    }

                    if (!reader.IsDBNull(2))
                    {

                        vis.diagnosis = reader.GetString(2);
                    }
                    if (!reader.IsDBNull(3))
                    {
                        vis.visitStatus = reader.GetString(3);
                    }
                    Patient p = FindPatient(reader.GetInt32(6));

                    vis.patientID = p;
                    v.Add(vis);
                }
            }
            connection.Close();
            return v;
        }

        public List<Exam> GetExams(int visitID)
        {
            List<Exam> exams = new List<Exam>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From EXAMINATION Where VISIT_ID= @examID";
            command.Parameters.AddWithValue("@examID", visitID);
            command.Connection = connection;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Exam dictionary = new Exam();
                    dictionary.examId = reader.GetInt32(0);
                    dictionary.resoult = reader.GetString(1);
                    dictionary.visitId = reader.GetInt32(2);
                    dictionary.examCode = reader.GetString(3);
                    exams.Add(dictionary);
                }
            }
            connection.Close();

            return exams;
        }
        public List<ExamDictionary> GetExamDictionaries()
        {
            List<ExamDictionary> exD = new List<ExamDictionary>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From EXAMINATION_DICTIONARY";
            command.Connection = connection;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ExamDictionary dictionary = new ExamDictionary();
                    dictionary.examDescription = reader.GetString(0);
                    dictionary.examCode = reader.GetString(1);
                    exD.Add(dictionary);
                }
            }
            connection.Close();
            return exD;
        }

        public System.Data.DataTable GetExamsData(int visitID)
        {
            System.Data.DataTable dataT = new System.Data.DataTable();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            /*string query = "SELECT EXAMINATION.RESOULT As Resoult, EXAMINATION_DICTIONARY.EXAM_DESCRIPTION as Description " +
                "From EXAMINATION " +
                "Full JOIN EXAMINATION_DICTIONARY " +
                "ON EXAMINATION.CODE = EXAMINATION_DICTIONARY.Code " +
                "EXAMINATION. VISIT_ID= " + visitID;
           */

            string query = "SELECT EXAMINATION.RESOULT As Resoult, EXAMINATION_DICTIONARY.EXAM_DESCRIPTION as Description From EXAMINATION FULL JOIN EXAMINATION_DICTIONARY ON EXAMINATION.CODE = EXAMINATION_DICTIONARY.Code Where EXAMINATION.VISIT_ID = "+ visitID;

            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(dataT);

            connection.Close();

            return dataT;
        }

        public System.Data.DataTable GetVisit(int doctorID)
        {
            System.Data.DataTable dataT = new System.Data.DataTable();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            /*string query = "SELECT EXAMINATION.RESOULT As Resoult, EXAMINATION_DICTIONARY.EXAM_DESCRIPTION as Description " +
                "From EXAMINATION " +
                "Full JOIN EXAMINATION_DICTIONARY " +
                "ON EXAMINATION.CODE = EXAMINATION_DICTIONARY.Code " +
                "EXAMINATION. VISIT_ID= " + visitID;
           */

            string query = "SELECT EXAMINATION.RESOULT As Resoult, EXAMINATION_DICTIONARY.EXAM_DESCRIPTION as Description From EXAMINATION FULL JOIN EXAMINATION_DICTIONARY ON EXAMINATION.CODE = EXAMINATION_DICTIONARY.Code Where EXAMINATION.VISIT_ID = "+doctorID;

            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(dataT);

            connection.Close();

            return dataT;
        }

        public Visit FindVisit(int i)
        {
            Visit vis = new Visit();
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            connection.Open();

            command.CommandText = "SELECT * From VISIT where visit_ID = @visitID";
            command.Parameters.AddWithValue("@visitID", i);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    vis.visitID = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                    {
                        vis.description = reader.GetString(1);
                    }

                    if (!reader.IsDBNull(2))
                    {

                        vis.diagnosis = reader.GetString(2);
                    }
                    if (!reader.IsDBNull(3))
                    {
                        vis.visitStatus = reader.GetString(3);
                    }
                    Patient p = FindPatient(reader.GetInt32(6));
                    Doctor d = FindDoctor(reader.GetInt32(4));
                    if (!reader.IsDBNull(5))
                    {
                        Receptionist r = FindReceptionist(reader.GetInt32(5));
                        vis.receptionistID = r;

                    }
                    vis.patientID = p;
                    vis.doctorID = d;

                }
            }

            connection.Close();

            return vis;
        }

        public Patient FindPatient(int id)
        {
            Patient p = new Patient();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From PATIENT where ID = @patientID";
            command.Parameters.AddWithValue("@patientID", id);
            command.Connection = connection;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    p.patientID = reader.GetInt32(5);
                    if (!reader.IsDBNull(0))
                    {
                        p.firstName = reader.GetString(0);
                    }
                    if (!reader.IsDBNull(1))
                    {
                        p.lastName = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        p.sex = reader.GetString(2)[0];
                    }
                    if (!reader.IsDBNull(4))
                    {
                        p.insuranceID = reader.GetString(4);
                    }
                    if (!reader.IsDBNull(3))
                    {
                        p.idNumber = reader.GetString(3);
                    }
                }
            }

            connection.Close();
            return p;
        }

        public Doctor FindDoctor(int id)
        {
            Doctor d = new Doctor();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From DOCTOR where CLINIC_EMPLOYEE_ID = @doctorID";
            command.Parameters.AddWithValue("@doctorID", id);
            command.Connection = connection;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        d.firstName = reader.GetString(0);
                    }
                    if (!reader.IsDBNull(1))
                    {
                        d.lastName = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        d.sex = reader.GetString(2)[0];
                    }
                    if (!reader.IsDBNull(3))
                    {
                        d.idNumber = reader.GetString(3);
                    }
                    d.employeeID = reader.GetInt32(4);

                    if (!reader.IsDBNull(5))
                    {
                        d.npwzID = reader.GetString(5);
                    }
                }
            }

            connection.Close();
            return d;
        }

        public User FindUser(string name)
        {
            User u = new User();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From [USER] where USER_NAME = @userName";
            command.Parameters.AddWithValue("@userName", name);

            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        u.userName = reader.GetString(0);
                    }
                    if (!reader.IsDBNull(1))
                    {
                        u.passwordName = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        u.active = reader.GetString(2)[0];
                    }
                    if (!reader.IsDBNull(3))
                    {
                        u.role = reader.GetString(3);
                    }
                    if (!reader.IsDBNull(4))
                    {
                        u.staffID = reader.GetInt32(4);
                    }
                }
            }

            connection.Close();
            return u;
        }
        public Receptionist FindReceptionist(int id)
        {
            Receptionist r = new Receptionist();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * From Receptionist where CLINIC_EMPLOYEE_ID = @receptionistID";
            command.Parameters.AddWithValue("@receptionistID", id);
            command.Connection = connection;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        r.firstName = reader.GetString(0);
                    }
                    if (!reader.IsDBNull(1))
                    {
                        r.lastName = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        r.sex = reader.GetString(2)[0];
                    }
                    if (!reader.IsDBNull(3))
                    {
                        r.idNumber = reader.GetString(3);
                    }
                    r.employeeID = reader.GetInt32(4);
                }
            }

            connection.Close();
            return r;
        }

        public void UpdateVisit(int id, string vDescription, string vStatus, string vDiagnosis)
        {
            DateTime dateTime = DateTime.Now; //current time
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE VISIT " +
                "Set VISIT_DESCRIPTION= @vDescripiton, Diagnosis = @vDiagnosis, Visit_Status =@vStatus , DT_FINISH_CANCELED= @dateTime " +
                "Where VISIT_ID = @visitId";
            command.Parameters.AddWithValue("@visitId", id);
            command.Parameters.AddWithValue("@vDescripiton", vDescription);
            command.Parameters.AddWithValue("@vDiagnosis", vDiagnosis);
            command.Parameters.AddWithValue("@vStatus", vStatus);
            command.Parameters.AddWithValue("@dateTime", dateTime);
            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void UpdatePatientData(int id, string lastName, string firstName, char sex, string nationalID, string insurance)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Patient " +
                "Set First_Name= @vfirstName, Last_Name = @vlastName, SEX = @vsex, " +
                "NATIONAL_ID_NUMBER=@vnationalID, INSURANCE_ID = @vinsurance " +
                "Where ID = @vID";
            command.Parameters.AddWithValue("@vID", id);
            command.Parameters.AddWithValue("@vfirstName", firstName);
            command.Parameters.AddWithValue("@vlastName", lastName);
            command.Parameters.AddWithValue("@vsex", sex);
            command.Parameters.AddWithValue("@vnationalID", nationalID);
            command.Parameters.AddWithValue("@vinsurance", insurance);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void UpdateReceptionistData(int id, string lastName, string firstName, char sex, string nationalID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Receptionist " +
                "Set First_Name= @vfirstName, Last_Name = @vlastName, SEX = @vsex, " +
                "NATIONAL_ID_NUMBER=@vnationalID " +
                "Where CLINIC_EMPLOYEE_ID = @vID";
            command.Parameters.AddWithValue("@vID", id);
            command.Parameters.AddWithValue("@vfirstName", firstName);
            command.Parameters.AddWithValue("@vlastName", lastName);
            command.Parameters.AddWithValue("@vsex", sex);
            command.Parameters.AddWithValue("@vnationalID", nationalID);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void UpdateDoctorData(int id, string lastName, string firstName, char sex, string nationalID, string NPWZ)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Doctor " +
                "Set First_Name= @vfirstName, Last_Name = @vlastName, SEX = @vsex, " +
                "NATIONAL_ID_NUMBER=@vnationalID, NPWZ_ID = @vnpwz " +
                "Where CLINIC_EMPLOYEE_ID = @vID";
            command.Parameters.AddWithValue("@vID", id);
            command.Parameters.AddWithValue("@vfirstName", firstName);
            command.Parameters.AddWithValue("@vlastName", lastName);
            command.Parameters.AddWithValue("@vsex", sex);
            command.Parameters.AddWithValue("@vnationalID", nationalID);
            command.Parameters.AddWithValue("@vnpwz", NPWZ);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void AddVisit(int patientID, int doctorID, int receptionistID, string description)
        {

            DateTime dateTime = DateTime.Now; //current time
            char[] vstatus = { 'R', 'E', 'G', 'I', 'S', 'T', 'E', 'R', 'D' };

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();


            command.CommandText = "INSERT INTO VISIT " +
              "(DOCTOR_ID, PATIENT_ID,RECEPTIONIST_ID, VISIT_STATUS,VISIT_DESCRIPTION,DT_REGISTRATION)" +
              "Values(@doctorId,@patientId,@receptionistId, 'REGISTERED',@description, @dateTime)";

            // command.Parameters.AddWithValue("@visitId", id);
            command.Parameters.AddWithValue("@doctorId", doctorID);
            command.Parameters.AddWithValue("@patientId", patientID);
            command.Parameters.AddWithValue("@receptionistId", receptionistID);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@dateTime", dateTime);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void AddPatient(string FirstName, string LastName, char sex, string nationalID, string insurance)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO PATIENT " +
             "(FIRST_NAME,LAST_NAME, SEX,NATIONAL_ID_NUMBER,INSURANCE_ID)" +
             "Values(@firstName,@lastName,@sex, @nationalID, @insurance)";

            command.Parameters.AddWithValue("@firstName", FirstName);
            command.Parameters.AddWithValue("@lastName", LastName);
            command.Parameters.AddWithValue("@sex", sex);
            command.Parameters.AddWithValue("@nationalID", nationalID);
            command.Parameters.AddWithValue("@insurance", insurance);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void AddReceptionist(string FirstName, string LastName, char sex, string nationalID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO RECEPTIONIST " +
             "(FIRST_NAME,LAST_NAME, SEX,NATIONAL_ID_NUMBER)" +
             "Values(@firstName,@lastName,@sex, @nationalID)";

            command.Parameters.AddWithValue("@firstName", FirstName);
            command.Parameters.AddWithValue("@lastName", LastName);
            command.Parameters.AddWithValue("@sex", sex);
            command.Parameters.AddWithValue("@nationalID", nationalID);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void AddDoctor(string FirstName, string LastName, char sex, string nationalID, string NPWZ)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO DOCTOR " +
             "(FIRST_NAME,LAST_NAME, SEX,NATIONAL_ID_NUMBER,NPWZ_ID)" +
             "Values(@firstName,@lastName,@sex, @nationalID, @npwz)";

            command.Parameters.AddWithValue("@firstName", FirstName);
            command.Parameters.AddWithValue("@lastName", LastName);
            command.Parameters.AddWithValue("@sex", sex);
            command.Parameters.AddWithValue("@nationalID", nationalID);
            command.Parameters.AddWithValue("@npwz", NPWZ);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void AddUser(string UserName, string Password, string Role)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO [USER] (USER_NAME, PASSWORD_HASH, ACTIVE, ROLE)" +
             "VALUES (@userName,@password,'1', @role)";

            command.Parameters.AddWithValue("@userName", UserName);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@role", Role);
            // command.Parameters.AddWithValue("@insurance", insurance);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();

        }

        public void AddUser(string UserName, string Password, string Role, int staffID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO [USER] (USER_NAME, PASSWORD_HASH, ACTIVE, ROLE,STAFF_ID)" +
             "VALUES (@userName,@password,'1', @role, @staffID)";

            command.Parameters.AddWithValue("@userName", UserName);
            command.Parameters.AddWithValue("@password", Password);
            command.Parameters.AddWithValue("@role", Role);
            command.Parameters.AddWithValue("@staffID", staffID);    

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();

        }

        public void AddExam(string resoult, int visitId, string code)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO EXAMINATION (RESOULT, VISIT_ID, CODE)" +
             "VALUES (@resoult,@visitID, @code)";

            command.Parameters.AddWithValue("@resoult", resoult);
            command.Parameters.AddWithValue("@visitID", visitId);
            command.Parameters.AddWithValue("@code", code);

            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }
        public int FindDoctorID()
        {
            List<Doctor> doctors = GetDoctors();

            int i = doctors.Last<Doctor>().employeeID;

            return i;
        }

        public int FindReceptionistID()
        {
            List<Receptionist> receptionists = GetReceptionists();

            int i = receptionists.Last<Receptionist>().employeeID;

            return i;
        }

    }
}

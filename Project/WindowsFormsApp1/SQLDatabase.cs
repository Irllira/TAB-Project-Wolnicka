using System;

namespace WindowsFormsApp1
{
    internal class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public char sex { get; set; }
        public string idNumber { get; set; }

    }

    internal class Staff : Person
    {
        public int employeeID { get; set; }
    }

    internal class Doctor : Staff
    {
        public string npwzID { get; set; }
    }

    internal class Receptionist : Staff
    {

    }

    internal class Patient : Person
    {
        public string insuranceID { get; set; }
        public int patientID { get; set; }

    }

    internal class Visit
    {
        public int visitID { get; set; }
        public string description { get; set; }
        public string diagnosis { get; set; }
        public string visitStatus { get; set; }
        public Patient patientID { get; set; }
        
        public Doctor doctorID;
        public Receptionist receptionistID { get; set; }

        public DateTime date { get; set; }
    }

    internal class User
    {
        public string userName { get; set; }
        public string passwordName { get; set; }
        public char active { get; set; }
        public string role { get; set; }
        public int staffID { get; set; }

        public string salt { get; set; }
    }

    internal class ExamDictionary
    {
        public string examDescription { get; set; }
        public string examCode { get; set; }
    }

    internal class Exam
    {
        public int examId { get; set; }
        public string resoult { get; set; }
        public int visitId { get; set; }
        public string examCode { get; set; }
    }
}

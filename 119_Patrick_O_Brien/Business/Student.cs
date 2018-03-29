using _119_Patrick_O_Brien.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace _119_Patrick_O_Brien.Business
{
    class Student
    {
        static AddData data = new AddData();
        static GetData getData = new GetData();
        static List<Student> students = new List<Student>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Level { get; set; }
        public string Course { get; set; }
        public string StudentID { get; set; }

        public Student()
        {

        }
            
        public Student(string firstName, string lastName, string email, string phone, string addressLine1, string addressLine2, string city, string county, string level, string course, string studentID)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            County = county;
            Level = level;
            Course = course;
            StudentID = studentID;
        }

        public Student(string studentID)
        {
            StudentID = studentID;
        }

        public void addtoDB()
        {
            data.AddStudent(FirstName, LastName, Email, Phone, AddressLine1, AddressLine2, City, County, Level, Course, StudentID);
        }
        public static void addStudent(string firstName, string lastName, string email, string phone, string addressLine1, string addressLine2, string city, string county, string level, string course, string studentID)
        {
            Student student = new Student(firstName, lastName, email, phone, addressLine1, addressLine2, city, county, level, course, studentID);
            students.Add(student);
            student.addtoDB();
        }

        public void updateDB()
        {
            data.UpdateStudent(FirstName, LastName, Email, Phone, AddressLine1, AddressLine2, City, County, Level, Course, StudentID);
        }

        public static void updateStudent(string firstName, string lastName, string email, string phone, string addressLine1, string addressLine2, string city, string county, string level, string course, string studentID)
        {
            Student student = new Student(firstName, lastName, email, phone, addressLine1, addressLine2, city, county, level, course, studentID);
            student.updateDB();
        }

        public void deleteFromDB()
        {
            data.DeleteStudent(StudentID);
        }

        public static void deleteStudent(string studentID)
        {
            Student student = new Student(studentID);
            student.deleteFromDB();
        }

        public DataTable getStudent(string studentID)
        {
            DataTable dt = getData.ReadStudent(studentID);
            return dt;

        }
    }
}

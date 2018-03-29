using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _119_Patrick_O_Brien.DataAccess
{
    class AddData:DAO
    {
        public void AddStudent(string firstName, string lastName, string email, string phone, string addressLine1, string addressLine2, string city, string county, string level, string course, string studentID)
        {
            SqlCommand cmd = new SqlCommand("insert into Student values( @Student_Number, @First_Name, @Last_Name, @Email, @Phone, @Address_Line_1, @Address_Line_2, @City, @County, @Level, @Course)", openConnection());
            cmd.Parameters.AddWithValue("@Student_Number", studentID);
            cmd.Parameters.AddWithValue("@First_Name", firstName);
            cmd.Parameters.AddWithValue("@Last_Name", lastName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Address_Line_1", addressLine1);
            cmd.Parameters.AddWithValue("@Address_Line_2", addressLine2);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@County", county);
            cmd.Parameters.AddWithValue("@Level", level);
            cmd.Parameters.AddWithValue("@Course", course);
            
            cmd.ExecuteNonQuery();
            closeConnnection();
        }

        public void AddLogin(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("insert into Login values(@Username, @Password)", openConnection());
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
            closeConnnection();
        }

        public void UpdateStudent(string firstName, string lastName, string email, string phone, string addressLine1, string addressLine2, string city, string county, string level, string course, string studentID)
        {
            SqlCommand cmd = new SqlCommand("Update student set(@First Name, @Last Name, @Email, @Phone, @Address Line 1, @Address Line 2, @City, @County, @Level, @Course) where [Student Number]=@StudentID");
            cmd.Parameters.AddWithValue("@First Name", firstName);
            cmd.Parameters.AddWithValue("@Last Name", lastName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Address Line 1", addressLine1);
            cmd.Parameters.AddWithValue("@Address Line 2", addressLine2);
            cmd.Parameters.AddWithValue("@City", city);
            cmd.Parameters.AddWithValue("@County", county);
            cmd.Parameters.AddWithValue("@Level", level);
            cmd.Parameters.AddWithValue("@Course", course);
            cmd.Parameters.AddWithValue("@StudentID", studentID);
            cmd.ExecuteNonQuery();
            closeConnnection();
        }

        public void DeleteStudent(string studentID)
        {
            SqlCommand cmd = new SqlCommand("Delete * FROM Student where [Student Number]=@StudentID");
            cmd.Parameters.AddWithValue("@StudentID", studentID);
            cmd.ExecuteNonQuery();
            closeConnnection();
        }
    }
}

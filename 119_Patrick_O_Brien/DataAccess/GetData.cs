using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _119_Patrick_O_Brien.DataAccess
{
    class GetData:DAO
    {
        //public SqlDataAdapter checkLogin(string username, string password)
        //{
        //    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM LOGIN WHERE Username=@Username and Password=@Password", openConnection());

        //    return sda;
        //}

        
        public DataTable ReadLogin(string username, string password)
        {
            DAO dao = new DAO();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM LOGIN WHERE Username=@Username and Password=@Password", openConnection());
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            //return dt;
        }

        public DataTable ReadStudent(string studentID)
        {
            DAO dao = new DAO();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE [Student Number]=@studentID", openConnection());
            cmd.Parameters.AddWithValue("@studentID", studentID);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public DataTable ReadAllStudent()
        {
            DAO dao = new DAO();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Student", openConnection());

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }
    }
}

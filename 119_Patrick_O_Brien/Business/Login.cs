using _119_Patrick_O_Brien.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _119_Patrick_O_Brien.Business
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        //public Login(string username, string password)
        //{
        //    Username = username;
        //    Password = password;
        //}

        public bool CheckLogin(string username, string password)
        {
            bool flag = false;
            try
            {
                GetData obj = new GetData();
                
                DataTable dt = obj.ReadLogin(username, password);

                if (dt.Rows[0][0].ToString() == "1")
                {

                    flag = true;
                  
                }
            }
            catch
            {
                throw;
            }

            return flag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows;
using System.Globalization;

namespace Airlines_amonic.MainCSFiles
{
    class ConnectToDB
    {
        public string ConnectionString { get; set; } = @"Persist Security Info=False;User ID=application;Password=zekindaplaneta;Initial Catalog=master;Data Source=DESKTOP-PSEJFIA\SQLEXPRESS";

        private void exec(string command)
        {
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command1 = new SqlCommand(command, conn);
                command1.ExecuteScalar();
                conn.Close();
            }
        }
        public void AddUser(User user)
        {
            if (CheckIfEmailIsNew(user.Email))
            {
                string command = "USE Session1_11 " + $"EXEC [dbo].AddUser '{user.RoleID}','{user.Email}', '{user.Password}', '{user.FirstName}', '{user.LastName}', '{user.OfficeID}', '{user.Birthdate}', '{user.Active}'";
                exec(command);
                MessageBox.Show("Пользователь добавлен");
            }
            else
            {
                MessageBox.Show("Пользователь с такой почтой уже существует");
            }

        }


        private bool CheckIfEmailIsNew(string email)
        {
            string command = "USE Session_11 " + $"select * from Users WHERE Email = '{email}'"; 
            List<User> users = new List<User>();
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.ID = reader.GetInt32(0);
                    users.Add(user);
                }
                reader.Close();
                conn.Close();
            }
            if (users.Count != 0)
                return false;
            else
                return true;
        }

        public List<User> GetUser()
        {

            string command = "USE Session_11 " + $"select * from Users"; 
            List<User> users = new List<User>();
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.ID = reader.GetInt32(0);
                    user.RoleID = reader.GetInt32(1);
                    user.Email = reader.GetString(2);
                    user.Password = reader.GetString(3);
                    user.FirstName = reader.GetString(4);
                    user.LastName = reader.GetString(5);
                    user.OfficeID = reader.GetInt32(6);
                    user.Birthdate = reader.GetDateTime(7);
                    user.Active = reader.GetBoolean(8);
                    user.age = Convert.ToString(DateTime.Now.Year - user.Birthdate.Year);
                    if (user.RoleID == 1) user.Role = "administrator";
                    else if (user.RoleID == 2) user.Role = "office user";
                    if (user.OfficeID == 1) user.Office = "Abu dhabi";
                    else if (user.OfficeID == 3) user.Office = "Cairo";
                    else if (user.OfficeID == 4) user.Office = "Bahrain";
                    else if (user.OfficeID == 5) user.Office = "Doha";
                    else if (user.OfficeID == 6) user.Office = "Riyadh";


                    users.Add(user);
                }
                reader.Close();
                conn.Close();
                return users;
            }

        }


        public List<User> GetUserWithOffice(int IDOffice)
        {

            string command = "USE Session_11 " + $"select * from Users Where OfficeID = {IDOffice}"; 
            List<User> users = new List<User>();
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.ID = reader.GetInt32(0);
                    user.RoleID = reader.GetInt32(1);
                    user.Email = reader.GetString(2);
                    user.Password = reader.GetString(3);
                    user.FirstName = reader.GetString(4);
                    user.LastName = reader.GetString(5);
                    user.OfficeID = reader.GetInt32(6);
                    user.Birthdate = reader.GetDateTime(7);
                    user.Active = reader.GetBoolean(8);
                    if (user.RoleID == 1) user.Role = "administrator";
                    else if (user.RoleID == 2) user.Role = "office user";
                    if (user.OfficeID == 1) user.Office = "Abu dhabi";
                    else if (user.OfficeID == 3) user.Office = "Cairo";
                    else if (user.OfficeID == 4) user.Office = "Bahrain";
                    else if (user.OfficeID == 5) user.Office = "Doha";
                    else if (user.OfficeID == 6) user.Office = "Riyadh";


                    users.Add(user);
                }
                reader.Close();
                conn.Close();
                return users;
            }

        }

        public List<User> GetUsersByLogin(string UserLogin)
        {

            string command = "USE Session_11 " + $"select* from Users WHERE Email = '{UserLogin}'"; 
            List<User> users = new List<User>();
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.ID = reader.GetInt32(0);
                    user.RoleID = reader.GetInt32(1);
                    user.Email = reader.GetString(2);
                    user.Password = reader.GetString(3);
                    user.FirstName = reader.GetString(4);
                    user.LastName = reader.GetString(5);
                    user.OfficeID = reader.GetInt32(6);
                    user.Birthdate = reader.GetDateTime(7);
                    user.Active = reader.GetBoolean(8);
                    users.Add(user);
                }
                reader.Close();
                conn.Close();
                return users;
            }
        }



        public void EditUser(User user)
        {
            string command = "USE Session_11 " + $"EXEC [dbo].EditUser '{user.RoleID}','{user.Email}', '{user.Password}', '{user.FirstName}', '{user.LastName}', '{user.OfficeID}', '{user.Birthdate}', '{user.Active}', {user.ID}";
            exec(command);
        }

        public User GetUsersForLogin(string UserLogin)
        {
            string command = "USE Session_11 " + $"select* from Users WHERE Email = '{UserLogin}'"; 
            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                User user = new User();
                conn.Open();
                SqlDataReader reader = new SqlCommand(command, conn).ExecuteReader();
                while (reader.Read())
                {
                    user.ID = reader.GetInt32(0);
                    user.RoleID = reader.GetInt32(1);
                    user.Email = reader.GetString(2);
                    user.Password = reader.GetString(3);
                    user.FirstName = reader.GetString(4);
                    user.LastName = reader.GetString(5);
                    user.OfficeID = reader.GetInt32(6);
                    user.Birthdate = reader.GetDateTime(7);
                    user.Active = reader.GetBoolean(8);
                }
                reader.Close();
                conn.Close();
                return user;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Login
{
    internal class DataAccess
    {
        private SqlConnection GetConnection
            = new SqlConnection(@"Data Source=(localdb)\localDBOXOTNIK;
                       Initial Catalog=Market;Integrated Security=True;");

        private static string salt = "key";

        public SqlConnection GetCon()
        {
            return GetConnection;
        }

        public void OpenCon()
        {
            if (GetConnection.State == ConnectionState.Broken)
            {
                GetConnection.Close();
            }
            if (GetConnection.State == ConnectionState.Closed)
            {
                GetConnection.Open();
            }
        }

        public void CloseCon()
        {
            if (GetConnection.State != ConnectionState.Closed)
            {
                GetConnection.Close();
            }
        }

        private string GenerateHash(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        public LoginStatus ChekLogin(string email, string pw)
        {
            using (var c = GetConnection)
            {
                c.Open();
                var cmd = new SqlCommand("SELECT * FROM Login WHERE Email=@email AND Password=@pw", c);
                var hash = GenerateHash(pw);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pw", hash);
                using (var read = cmd.ExecuteReader())
                {
                    if (read.Read())
                    {
                        if (!string.IsNullOrEmpty(read["Code"] + string.Empty))
                        {
                            return LoginStatus.NeedVerify;
                        }
                        else if (!string.IsNullOrEmpty(read["Email"] + string.Empty))
                        {
                            return LoginStatus.OK;
                        }
                        else
                        {
                            return LoginStatus.Incorrect;
                        }
                    }

                }
                return LoginStatus.NotExist;
            }
        }

        public bool SignUp(string email, string pw)
        {
            LoginStatus loginstatus = ChekLogin(email, pw);
            if (loginstatus == LoginStatus.NotExist)
            {
                using (var c = GetConnection)
                {
                    c.Open();
                    var hash = GenerateHash(pw);
                    var code = new Random().Next(9999);
                    var cmd = new SqlCommand("INSERT INTO Login(Email,Password,Code) VALUES(@email,@pw,@code)",c);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pw", hash);
                    cmd.Parameters.AddWithValue("@code", code);
                    var mailhelp = new EmailRegistr();
                    mailhelp.SendEmail(code+string.Empty, email);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            return false;
        }

        public bool VerifyCode(string email,string pw,string code)
        {
            LoginStatus loginStatus = ChekLogin(email,pw);
            if (loginStatus != LoginStatus.NeedVerify)
            {
                return false;
            }
            using (var c = GetConnection)
            {
                c.Open();
                var cmd = 
                    new SqlCommand("SELECT Code FROM Login WHERE Email=@email", c);
                cmd.Parameters.AddWithValue("@email",email);
                if (cmd.ExecuteScalar().ToString() == code)
                {
                    var cmdUpdate = 
                        new SqlCommand("UPDATE Login SET Code = NULL WHERE Email=@email",c);
                    cmdUpdate.Parameters.AddWithValue("@email",email);
                    return cmdUpdate.ExecuteNonQuery() > 0;
                }
                return false;
            }
        }
    }
}

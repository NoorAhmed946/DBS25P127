using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBS25P127
{
    public static class loginC
    {
        public static (bool isValid, int userId, int roleId) ValidateLogin(string username, string password)
        {
            string query = $"SELECT user_id, role_id FROM users WHERE username = '{username}' AND password_hash = '{password}'";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32("user_id");
                            int roleId = reader.GetInt32("role_id");
                            return (true, userId, roleId);
                        }
                        else
                        {
                            return (false, -1, -1);
                        }
                    }
                }
            }
        }

        public static int GetFacultyIdByUserId(int userId)
        {
            string query = $"SELECT faculty_id FROM faculty WHERE user_id = {userId}";
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }


    }
}
   

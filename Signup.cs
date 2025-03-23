using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBS25P127
{
    public class Signup
    {
        public static bool CreateUserAccount(string username, string email, string password, int roleId)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.Instance.getConnection())
                {
                    string query = "INSERT INTO users (username, email, password_hash, role_id) VALUES (@username, @email, @password, @roleId)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@roleId", roleId);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            long userId = cmd.LastInsertedId;

                            // update faculty table
                            string updateQuery = "UPDATE faculty SET user_id = @userId WHERE email = @facultyEmail";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@userId", userId);
                                updateCmd.Parameters.AddWithValue("@facultyEmail", email);
                                updateCmd.ExecuteNonQuery();
                            }

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public static DataTable LoadUnregisteredFacultyEmails()
        {
            using (MySqlConnection con = DatabaseHelper.Instance.getConnection())
            {
                string query = "SELECT email FROM faculty WHERE user_id IS NULL";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBS25P127
{
    public static class RequestF
    {
        public static bool SubmitRequest(int facultyId, int itemId, int quantity)
        {
            try
            {
                string query = $@"
                INSERT INTO faculty_requests (faculty_id, item_id, quantity, status_id, request_date)
                VALUES ({facultyId}, {itemId}, {quantity}, 8, NOW())";

                int result = DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error submitting request: " + ex.Message);
                return false;
            }
        }

        public static DataTable GetFacultyRequests(int facultyId)
        {
            DataTable table = new DataTable();
            try
            {
                string query = $"SELECT request_id, item_id, quantity, status_id, request_date FROM faculty_requests WHERE faculty_id = {facultyId}";

                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading requests: " + ex.Message);
            }


            return table;
        }

        public static DataTable GetFacultyCourses(int facultyId)
        {
            string query = @"
        SELECT 
            fc.faculty_course_id,
            f.name,
            c.course_name,
            s.term
        FROM faculty_courses fc
        JOIN faculty f ON fc.faculty_id = f.faculty_id
        JOIN courses c ON fc.course_id = c.course_id
        JOIN semesters s ON fc.semester_id = s.semester_id
        WHERE fc.faculty_id = @facultyId";

            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@facultyId", facultyId);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // DEPARTMENT HEAD FUNCTIONS 

        public static int UpdateRequestStatus(int requestId, int statusId)
        {
            string query = $"UPDATE request SET status_id = {statusId} WHERE request_id = {requestId}";
            int result = DatabaseHelper.Instance.Update(query);
            return result;
        }

        public static DataTable GetRequestStatuses()
        {
            string query = "SELECT lookup_id, value FROM lookup WHERE category = 'RequestStatus' AND value != 'Fulfilled'";
            DataTable statusTable = new DataTable();

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                statusTable.Load(reader);
            }

            return statusTable;
        }

        public static DataTable GetAllFacultyRequests()
        {
            string query = @"
        SELECT 
            r.request_id,
            f.name AS faculty_name,
            i.name AS item_name,
            r.quantity,
            l.value AS status,
            r.request_date
        FROM 
            requests r
        JOIN faculty f ON r.faculty_id = f.faculty_id
        JOIN items i ON r.item_id = i.item_id
        JOIN lookup l ON r.status_id = l.lookup_id
        WHERE l.category = 'RequestStatus'
        ORDER BY r.request_date DESC;
    ";

            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);

            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();

            return dt;
        }

     

        // ADMIN FUNCTION 

        public static DataTable GetAdminOp()
        {
            string query = "SELECT lookup_id, value FROM lookup WHERE category = 'RequestStatus' AND value = 'Fulfilled'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);

            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            return dt;
        }
    }
}

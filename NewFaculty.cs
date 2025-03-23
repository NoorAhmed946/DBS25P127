using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBS25P127
{
    internal class NewFaculty
    {
        public string name;
        public string email;
        public string contact;
        public string research_area;
        public int total_teaching_hours;
        public string designation;

        public NewFaculty(string name, string email, string contact, string researchArea, int teachingHours, string designation)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.research_area = researchArea;
            this.total_teaching_hours = teachingHours;
            this.designation = designation;
        }

        //  Add Faculty
        public static bool AddFaculty(string name, string email, string contact, string researchArea, int teachingHours, string designation)
        {
            string query = $@"
        INSERT INTO faculty (name, email, contact, research_area, total_teaching_hours, designation_id, user_id)
        VALUES (
            '{name}', 
            '{email}', 
            '{contact}', 
            '{researchArea}', 
            {teachingHours},
            (SELECT lookup_id FROM lookup WHERE value = '{designation}' AND category = 'Designations' LIMIT 1),
            NULL
        );";

            DatabaseHelper.Instance.Update(query);
            return true;
        }

        //  Delete Faculty
        public static bool DeleteFaculty(int id)
        {
            string query = $"DELETE FROM faculty WHERE faculty_id = {id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // Update Faculty
        public static bool UpdateFaculty(int id, string name, string email, string contact, string researchArea, int teachingHours, string designation)
        {
            string query = $@"
        UPDATE faculty 
        SET 
            name = '{name}', 
            email = '{email}', 
            contact = '{contact}',
            research_area = '{researchArea}', 
            total_teaching_hours = {teachingHours},
            designation_id = (SELECT lookup_id FROM lookup WHERE value = '{designation}'AND category = 'Designations' LIMIT 1)
        WHERE faculty_id = {id}";

            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // FACULTY COURSE SCHEDULE FUNCTIONS 

        // Add Function 
        public static bool AddFacultySchedule(int facultyCourseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            string query = $@"
        INSERT INTO faculty_course_schedule (faculty_course_id, room_id, day_of_week, start_time, end_time)
        VALUES ({facultyCourseId}, {roomId}, '{dayOfWeek}', '{startTime}', '{endTime}')";

            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // Update Function 
        public static bool UpdateFacultySchedule(int scheduleId, int facultyCourseId, int roomId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            string query = $@"
        UPDATE faculty_course_schedule 
        SET faculty_course_id = {facultyCourseId}, 
            room_id = {roomId}, 
            day_of_week = '{dayOfWeek}', 
            start_time = '{startTime}', 
            end_time = '{endTime}'
        WHERE schedule_id = {scheduleId}";

            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // SCHEDULE OVERLAPPING CHECK   
        public static bool IsScheduleOverlapping(int facultyId, string dayOfWeek, TimeSpan startTime, TimeSpan endTime)
        {
            string query = $@"
            SELECT COUNT(*) AS overlap_count
            FROM faculty_course_schedule fcs
            JOIN faculty_courses fc ON fcs.faculty_course_id = fc.faculty_course_id
            WHERE fc.faculty_id = {facultyId}
              AND fcs.day_of_week = '{dayOfWeek}'
              AND (
                    fcs.start_time < '{endTime}' AND fcs.end_time > '{startTime}'
                  )
        ";

            using (MySqlDataReader reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    int overlapCount = Convert.ToInt32(reader["overlap_count"]);
                    return overlapCount > 0;
                }
            }

            return false;
        }

        // FACULTY COURSE ID 
        public static int GetFacultyIdFromFacultyCourseId(int facultyCourseId)
        {
            string query = $"SELECT faculty_id FROM faculty_courses WHERE faculty_course_id = {facultyCourseId}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    return Convert.ToInt32(reader["faculty_id"]);
                }
            }
            return -1; 
        }

        // FACULTY ADMIN ROLES 

        public static bool AddAdminRole(int facultyId, string roleName, int semesterId)
        {
            using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            {
                string query = @"INSERT INTO faculty_admin_roles (faculty_id, role_name, semester_id)
                         VALUES (@facultyId, @roleName, @semesterId)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@facultyId", facultyId);
                cmd.Parameters.AddWithValue("@roleName", roleName);
                cmd.Parameters.AddWithValue("@semesterId", semesterId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }

            // update function for faculty  roles 

            //    public static bool UpdateAdminRole(int roleId, int facultyId, string roleName, int semesterId)
            //{
            //    using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
            //    {
            //        string query = @"UPDATE faculty_admin_roles
            //                 SET faculty_id = @facultyId,
            //                     role_name = @roleName,
            //                     semester_id = @semesterId
            //                 WHERE admin_role_id = @roleId";

            //        MySqlCommand cmd = new MySqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@facultyId", facultyId);
            //        cmd.Parameters.AddWithValue("@roleName", roleName);
            //        cmd.Parameters.AddWithValue("@semesterId", semesterId);
            //        cmd.Parameters.AddWithValue("@roleId", roleId);

            //        conn.Open();
            //        int rowsAffected = cmd.ExecuteNonQuery();
            //        conn.Close();

            //        return true;
            //    }
            //}

            // DELETE FUNCTION 

        //    public static bool DeleteAdminRole(int roleId)
        //{
        //    using (MySqlConnection conn = DatabaseHelper.Instance.getConnection())
        //    {
        //        string query = @"DELETE FROM faculty_admin_roles
        //                 WHERE admin_role_id = @roleId";

        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@roleId", roleId);

        //        conn.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        conn.Close();

        //        return true;
        //    }
        //}


    }

}
}

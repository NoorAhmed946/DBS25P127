using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS25P127
{
    internal class NewCourse
    {
        public string course_name;
        public string course_type;
        public int credit_hours;
        public int contact_hours;

        public NewCourse(string courseName, string courseType, int creditHours, int contactHours)
        {
            this.course_name = courseName;
            this.course_type = courseType;
            this.credit_hours = creditHours;
            this.contact_hours = contactHours;
        }
        // Add Course
        public static bool AddCourse(string name, string type, int credit, int contact)
        {
            string query = $"INSERT INTO courses (course_name, course_type, credit_hours, contact_hours) VALUES ('{name}', '{type}', {credit}, {contact})";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // Delete Course
        public static bool DeleteCourse(int id)
        {
            string query = $"DELETE FROM courses WHERE course_id = {id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // Update Course
        public static bool UpdateCourse(int id ,string name, string type, int credit, int contact)
        {
            string query = $"UPDATE courses SET course_name = '{name}', course_type = '{type}', credit_hours = {credit}, contact_hours = {contact} WHERE course_id = {id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        public static int GetFacultyAssignedHours(int facultyId) // Assigned 
        {
            int totalAssignedHours = 0;
            string query = $@"
            SELECT COALESCE(SUM(c.contact_hours), 0) AS total_assigned_hours
            FROM faculty_courses fc
            JOIN courses c ON fc.course_id = c.course_id
            WHERE fc.faculty_id = {facultyId}";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    totalAssignedHours = Convert.ToInt32(reader["total_assigned_hours"]);
                }
            }

            return totalAssignedHours;
        }

        public static int GetCourseContactHours(int courseId)
        {
            int contactHours = 0;
            string query = $"SELECT contact_hours FROM courses WHERE course_id = {courseId}";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    contactHours = Convert.ToInt32(reader["contact_hours"]);
                }
            }

            return contactHours;
        }

        public static int GetFacultyTeachingLimit(int facultyId)
        {
            int limit = 0;
            string query = $"SELECT total_teaching_hours FROM faculty WHERE faculty_id = {facultyId}";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                if (reader.Read())
                {
                    limit = Convert.ToInt32(reader["total_teaching_hours"]);
                }
            }

            return limit;
        }

    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P127
{
    internal class facultyCourses
    {
        public static bool AddFacultyCourse(int facultyId, int courseId, int semesterId)
        {
            string query = $@"
                INSERT INTO faculty_courses (faculty_id, course_id, semester_id)
                VALUES ({facultyId}, {courseId}, {semesterId})";
                DatabaseHelper.Instance.Update(query);
                return true;
        }

        public static bool UpdateFacultyCourse(int id, int facultyId, int courseId, int semesterId)
        {
            string query = $@"
                UPDATE faculty_courses 
                SET faculty_id = {facultyId}, 
                    course_id = {courseId}, 
                    semester_id = {semesterId}
                WHERE id = {id}";

                DatabaseHelper.Instance.Update(query);
            return true;
        }

    }
}

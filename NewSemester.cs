using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P127
{
    internal class NewSemester
    {
        public string? term;
        public int  year;

        NewSemester(string term , int year ) 
        {
            this.term = term;
            this.year = year;
        }

        // QUERIES 

        public static bool AddSemester(string term, int year)
        {
            string query = $"INSERT INTO semesters (term, year) VALUES ('{term}', {year})";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // ✏️ Update Semester
        public static bool UpdateSemester(int semesterId, string term, int year)
        {
            string query = $"UPDATE semesters SET term = '{term}', year = {year} WHERE semester_id = {semesterId}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // ❌ Delete Semester
        public static bool DeleteSemester(int semesterId)
        {
            string query = $"DELETE FROM semesters WHERE semester_id = {semesterId}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

    }
}

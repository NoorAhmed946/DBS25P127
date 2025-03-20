using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P127
{
    internal class NewProject
    {
        public string? title;
        public string? description;

        public NewProject(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        // Add Project
        public static bool AddProject(string title, string description)
        {
            string query = $"INSERT INTO projects (title, description) VALUES ('{title}', '{description}')";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // Update Project
        public static bool UpdateProject(int project_id, string title, string description)
        {
            string query = $"UPDATE projects SET title = '{title}', description = '{description}' WHERE project_id = {project_id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }

        // Delete Project
        public static bool DeleteProject(int project_id)
        {
            string query = $"DELETE FROM projects WHERE project_id = {project_id}";
            DatabaseHelper.Instance.Update(query);
            return true;
        }


        // FACULTY PROJECTS TABLE FUNCTIONS 
        public static bool AddFacultyProject(int facultyId, int projectId, int semesterId, int supervisionHours)
        {
            string query = $@"
        INSERT INTO faculty_projects (faculty_id, project_id, semester_id, supervision_hours)
        VALUES ({facultyId}, {projectId}, {semesterId}, {supervisionHours})";

            DatabaseHelper.Instance.Update(query);
            return true;
        }

        public static bool UpdateFacultyProject(int id, int facultyId, int projectId, int semesterId, int supervisionHours)
        {
            string query = $@"
        UPDATE faculty_projects 
        SET faculty_id = {facultyId}, 
            project_id = {projectId}, 
            semester_id = {semesterId}, 
            supervision_hours = {supervisionHours}
        WHERE faculty_project_id = {id}";

            DatabaseHelper.Instance.Update(query);
            return true;
        }

    }
}

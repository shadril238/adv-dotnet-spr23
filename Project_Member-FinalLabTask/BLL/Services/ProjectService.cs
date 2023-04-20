using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProjectService
    {
        //Convertion Methods
        static ProjectDTO Convert(Project project)
        {
            return new ProjectDTO()
            {
                Id = project.Id,
                Title = project.Title,
                Status = project.Status,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
            };
        }
        static Project Convert(ProjectDTO project)
        {
            return new Project()
            {
                Id = project.Id,
                Title = project.Title,
                Status = project.Status,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
            };
        }
        static List<ProjectDTO> Convert(List<Project> Project)
        {
            var data=new List<ProjectDTO>();
            foreach (var item in Project)
            {
                data.Add(Convert(item));
            }
            return data;
        }

        //CRUD
        public static List<ProjectDTO> Get()
        {
            var data = DataAccessFactory.ProjectData().Get();
            return Convert(data);
        }

        public static ProjectDTO Get(int id)
        {
            var data = DataAccessFactory.ProjectData().Get(id);
            return Convert(data);
        }

        public static bool Insert(ProjectDTO project)
        {
            var data = Convert(project);
            return DataAccessFactory.ProjectData().Insert(data);
        }
        public static bool Update(ProjectDTO project)
        {
            var data = Convert(project);
            return DataAccessFactory.ProjectData().Update(data);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ProjectData().Delete(id);
        }
    }
}

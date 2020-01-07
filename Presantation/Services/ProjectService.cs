using Data.Database;
using Data.Dto;
using Newtonsoft.Json;
using Presantation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presantation.Services
{
    public class ProjectService : IProjectService
    {
        wcfappEntities entities = new wcfappEntities();

        /// <summary>
        /// Project tablosuna kayıt ekler
        /// </summary>
        /// <param name="projectDto">Eklenecek proje nesnesi</param>
        /// <returns></returns>
        public string AddProject(ProjectDto projectDto)
        {
            project addProject = new project { Id = projectDto.Id, Name = projectDto.Projectname };
            entities.projects.Add(addProject);
            entities.SaveChanges();
            return JsonConvert.SerializeObject(projectDto);
        }

        /// <summary>
        /// ProjectRole tablosuna kayıt ekler
        /// </summary>
        /// <param name="projectRoleDto">Eklenecek projectrole nesnesi</param>
        /// <returns></returns>
        public string AddProjectRole(projectrole addProjectrole)
        {
            entities.projectroles.Add(addProjectrole);
            entities.SaveChanges();
            return JsonConvert.SerializeObject(addProjectrole);
        }

        /// <summary>
        /// İstenilen proje kaydını ProjectDto olarak dönderir.
        /// </summary>
        /// <param name="projectId">Dönderilecek proje id'si</param>
        /// <returns></returns>
        public string GetProject(int projectId)
        {
            var getProject = entities.projects.Where(x => x.Id == projectId).FirstOrDefault();
            ProjectDto projectDto = new ProjectDto { Id = getProject.Id, Projectname = getProject.Name };
            return JsonConvert.SerializeObject(projectDto);
        }

        /// <summary>
        /// İstenilen projectroles kaydının bilgilerini ProjectRoleDto olarak dönderir.
        /// </summary>
        /// <param name="projectId">İstenilen kaydın projeId'si</param>
        /// <returns></returns>
        public List<ProjectRoleDto> GetProjectRoles(int projectId)
        {
            //ToDO:Burası yazılacak.
            return null;

        }
    }
}
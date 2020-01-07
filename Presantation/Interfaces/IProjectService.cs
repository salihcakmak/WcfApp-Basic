using Data.Database;
using Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Presantation.Interfaces
{
    [ServiceContract]
    public interface IProjectService
    {
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "AddProject")]
        string AddProject(ProjectDto projectDto);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "AddProjectRole",
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string AddProjectRole(projectrole projectRoleDto);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
            Method = "GET",
            UriTemplate = "GetProject?projectId={projectId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string GetProject(int projectId);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare,
            Method = "GET",
            UriTemplate = "GetProjectRoles?projectId={projectId}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string GetProjectRoles(int projectId);
    }
}

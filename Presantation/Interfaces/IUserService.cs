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
    public interface IUserService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "AddUser",
        BodyStyle = WebMessageBodyStyle.Bare,
        Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string AddUser(SaveUserDto userDto);

        [OperationContract]
        [WebInvoke(UriTemplate = "GetUser?userId={UserId}",
        BodyStyle =WebMessageBodyStyle.Bare,
        Method ="GET",
        RequestFormat =WebMessageFormat.Json,
        ResponseFormat =WebMessageFormat.Json)]
        //GET Method'lar parametre olarak int alamaz.
        //GET metot istekleri sadece urlden verilir body'si bulunmaz.
        string GetUser(int UserId);

    }
}

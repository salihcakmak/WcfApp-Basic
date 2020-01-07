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
    public class UserService : IUserService
    {
        //Database işlemleri için kullanılacak nesne.
        wcfappEntities entities = new wcfappEntities();

        /// <summary>
        /// User tablosuna kayıt ekler
        /// </summary>
        /// <param name="userDto">Eklenecek entity nesnesi</param>
        /// <returns></returns>
        public string AddUser(SaveUserDto userDto)
        {
            user addUser = new user
            {
                Name = userDto.Name,
                Password = userDto.Password,
                Username = userDto.Username
            };
            entities.users.Add(addUser);
            entities.SaveChanges();

            return JsonConvert.SerializeObject(userDto);
        }

        /// <summary>
        /// İstenilen user kaydını döner
        /// </summary>
        /// <param name="UserId">Dönderilecek userId</param>
        /// <returns></returns>
        public string GetUser(int UserId)
        {
            var user = entities.users.Where(x => x.Id == UserId).FirstOrDefault();
            UserDto userDto = new UserDto { Id = user.Id, Name = user.Name, Username = user.Username };
            return JsonConvert.SerializeObject(userDto);
        }
    }
}
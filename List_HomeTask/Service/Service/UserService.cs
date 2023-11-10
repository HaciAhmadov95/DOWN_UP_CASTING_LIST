using Service.Data;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserService : IUserService
    {
        public string Login(string userName, string password)
        {
            return AppDbContext.Users().Where(m => m.Username == userName && m.Password == password).ToString();
        }
    }
}

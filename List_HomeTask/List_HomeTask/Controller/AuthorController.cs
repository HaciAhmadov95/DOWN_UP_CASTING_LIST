using Service.Service;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_HomeTask.Controller
{
    internal class AuthorController
    {
        private readonly IAuthorService _service;

        public AuthorController()
        {
            _service = new AuthorService();
        }
        public void GetByAge()
        {
            var datas = _service.GetAllAuthors();
            foreach (var data in datas)
            {
                if (data.Age > 40)
                {
                    Console.WriteLine(data.Name + " " + data.Surname);
                }
            }
        }
    }
}

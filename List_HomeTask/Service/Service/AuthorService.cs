using Domain.Models;
using Service.Data;
using Service.Service.Interface;

namespace Service.Service
{
    public class AuthorService : IAuthorService
    {
        public List<Author> AuthorsOver40(int age)
        {
            return AppDbContext.Authors();
        }


        public List<Author> GetAllAuthors()
        {
            return AppDbContext.Authors();
        }
    }
}

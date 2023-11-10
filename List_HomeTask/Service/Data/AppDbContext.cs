using Domain.Models;

namespace Service.Data
{
    public static class AppDbContext
    {
        public static List<Author> Authors()
        {
            return new List<Author>
            {
                new Author
                {
                    Name = "Mikhail",
                    Surname = "Bulgakov",
                    Age = 42
                },
                new Author
                {

                    Name = "Jack",
                    Surname = "London",
                    Age = 36
                },
                new Author
                {
                    Name = "Erich",
                    Surname = "Remark",
                    Age = 49
                }
            };
        }

        public static List<Employee> Employees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Mermer",
                    Surname = "Ismayilova",
                    Salary = 1800,
                    Birthday = new (2001,01,20)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ali",
                    Surname = "Aslanov",
                    Salary = 2200,
                    Birthday = new (2003,07,12)
                },
                new Employee
                {
                    Id = 3,
                    Name = "Leman",
                    Surname = "Memmedova",
                    Salary = 2900,
                    Birthday = new (2002,11,23)
                }
            };
                
        }


        public static List<User> Users()
        {
            return new List<User>
            {
                new User
                {
                    Username = "Haci1995",
                    Password = "Haci123",

                },
                new User
                {
                    Username = "Ali",
                    Password = "Ali123"
                }
            };
        }

        public static List<Product> Products()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "Acer",
                    Price = 2000,
                    Sort = "Computer"
                },
                new Product
                {
                    Name = "Lenovo",
                    Price = 3000,
                    Sort = "Computer"
                }
            };
        }
    }
}
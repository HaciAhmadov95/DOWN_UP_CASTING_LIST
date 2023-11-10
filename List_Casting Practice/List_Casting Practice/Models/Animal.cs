using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Casting_Practice.Models
{
    internal class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }


        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    
}

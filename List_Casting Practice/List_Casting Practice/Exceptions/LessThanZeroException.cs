using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Casting_Practice.Exceptions
{
    internal class LessThanZeroException:Exception
    {
        public LessThanZeroException() : this("Cannot be less than zero")
        {
            
        }
        public LessThanZeroException(string message) : base(message) 
        {
            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExceptionsApp
{

    public class UserAgeException : ArgumentException
    {
        public UserAgeException(string message = "Non correct age value")
            : base(message)
        { }
    }
    internal class User
    {
        int age;
        public string Name { set; get; }
        public int Age 
        { 
            set
            {
                if (value > 0 && value < 100)
                    age = value;
                else
                    throw new UserAgeException();
            }
            get => age;
        }

    }
}

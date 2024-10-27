using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Models
{
    internal class User
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private string _surname { get; set; }
        private static int _age { get; set; }

        private void GetFullName()
        {
            Console.WriteLine($"{_name} {_surname}");
        }

        private static void ChangeAge(int age)
        {
            _age = age;
        }
    }
}

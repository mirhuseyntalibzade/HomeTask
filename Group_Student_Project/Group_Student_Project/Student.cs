using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Student_Project
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public byte Age { get; set; }
        public string PhoneNumber { get; set; }

        private byte _limit = 4;
        public byte Limit { 
            get 
            {
                return _limit;
            } 
            set 
            {
                if (value >= 0)
                {
                    _limit = value;   
                }
            } 
        }
        public Group Group { get; set; }
        public void Absent()
        {
            if (_limit == 0)
            {
                Console.WriteLine("You have been dismissed.");
            }

            if (_limit > 0)
            {
                Limit--;
                Console.WriteLine("The student is absent today.");
            }
        }
    }
}

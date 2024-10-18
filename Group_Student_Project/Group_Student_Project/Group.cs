using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Student_Project
{
    internal class Group
    {
        public string Name;

        public bool Shift;
        
        public Student[] Students = [];
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);

            Students[Students.Length - 1] = student;
        }
        public Student FindStudent(string name)
        {
            foreach (var studentName in Students)
            {
                if (name.ToLower() == studentName.Name.ToLower())
                {
                    return studentName;
                }
            }
            return null;
        }
    }
}

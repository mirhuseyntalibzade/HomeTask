namespace Group_Student_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the classroom! Please choose which operation you would like to do.");
            Console.WriteLine("1. Create Group");
            Console.WriteLine("2. Create Student and add it to specific group");
            Console.WriteLine("3. Mark the student as absent.");
            Console.WriteLine("4. Search for the student in group.");
            Console.WriteLine("5. Exit.\n");

            Group group = null;

            while (true)
            {
                string operation = Console.ReadLine();
                if (operation == "5")
                {
                    break;
                }
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("What is your group name?");
                        string groupName = Console.ReadLine();
                        Console.WriteLine($"What is the shift of your group {groupName}? (morning / afternoon)");
                        while (true)
                        {
                            string groupShift = Console.ReadLine().ToLower();

                            if (groupShift == "morning" || groupShift == "afternoon")
                            {
                                bool isMorning = groupShift == "morning";
                                group = new Group { Name = groupName, Shift = isMorning };
                                Console.WriteLine($"Group {groupName} ({groupShift}) created successfully!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid shift. Please enter 'morning' or 'afternoon'.");
                            }
                        }
                        break;

                    case "2":
                        if (group == null)
                        {
                            Console.WriteLine("You have to create a group first!");
                            break;
                        }

                        Console.WriteLine("What is the name of the student?");
                        string studentName = Console.ReadLine();
                        Console.WriteLine("What is the surname of the student?");
                        string studentSurname = Console.ReadLine();

                        bool gender = false;
                        while (true)
                        {
                            Console.WriteLine("What is the gender of the student? (male / female)");
                            string genderInput = Console.ReadLine().ToLower();
                            if (genderInput == "male")
                            {
                                gender = true;
                                break;
                            }
                            else if (genderInput == "female")
                            {
                                gender = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'male' or 'female'.");
                            }
                        }

                        Console.WriteLine("What is the age of the student?");
                        byte age = byte.Parse(Console.ReadLine());

                        Console.WriteLine("What is the phone number of the student?");
                        string phoneNumber = Console.ReadLine();

                        Student student = new Student
                        {
                            Name = studentName,
                            Surname = studentSurname,
                            Gender = gender,
                            Age = age,
                            PhoneNumber = phoneNumber,
                            Group = group
                        };

                        group.AddStudent(student);
                        break;

                    case "3":
                        Console.WriteLine("Enter the student's name to mark as absent:");
                        string absentStudentName = Console.ReadLine();
                        if (group == null)
                        {
                            Console.WriteLine("You have to create a group first!");
                        }
                        else
                        {
                            Student absentStudent = group.FindStudent(absentStudentName);
                            if (absentStudent != null)
                            {
                                absentStudent.Absent();
                            }
                            else
                            {
                                Console.WriteLine("Student not found in the group.");
                            }
                        }

                        break;

                    case "4":
                        Console.WriteLine("Enter the student's name to search:");
                        string searchName = Console.ReadLine();
                        if (group == null)
                        {
                            Console.WriteLine("You have to create a group first!");
                        }
                        else
                        {
                            Student foundStudent = group.FindStudent(searchName);
                            if (foundStudent != null)
                            {
                                Console.WriteLine($"{foundStudent.Name} {foundStudent.Surname} is in the group {group.Name}.");
                            }
                            else
                            {
                                Console.WriteLine("Student not found.");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine($"Invalid command. Please try again.");
                        break;
                }
            }
        }
    }
}

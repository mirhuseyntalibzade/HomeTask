using Access_Modifiers.Models;
using CustomValidator.Models;
using System;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "", name = "", surname = "", password = "";
            byte age = 0;
            DateTime birthday = DateTime.MinValue;
            CustomValidatorClass validator = new CustomValidatorClass();

            Console.WriteLine("Creating new user...");

            while (true)
            {
                Console.Write("Username: ");
                username = Console.ReadLine();
                if (validator.ValidateUserName(username))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Username must be minimum 2 symbols.");
                }
            }
            while (true)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                if (validator.ValidateName(name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Name must be minimum 2 symbols.");
                }
            }
            while (true)
            {
                Console.Write("Surname: ");
                surname = Console.ReadLine();
                if (validator.ValidateSurName(surname))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Surname must be minimum 2 symbols.");
                }
            }
            while (true)
            {
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (validator.ValidatePassword(password))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Password must be 8 symbols long and must include digit, symbol, upper and lower case letters.");
                }
            }
            while (true)
            {
                Console.Write("Age: ");
                if (byte.TryParse(Console.ReadLine(), out age) && validator.ValidateAge(age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Age must be above than 0.");
                }
            }

            while (true)
            {
                Console.Write("Birthday: (yyyy-mm-dd)");
                if (DateTime.TryParse(Console.ReadLine(), out birthday) && validator.ValidateBirthday(birthday))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Birthday cannot be lower than 1970.");
                }
            }

            Person newPerson = new Person(username, password, name, surname, age, birthday);
            Console.WriteLine("New user has been created successfully.");
        }
    }
}

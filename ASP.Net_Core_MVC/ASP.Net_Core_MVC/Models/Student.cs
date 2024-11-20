namespace ASP.Net_Core_MVC.Models
{
    public class Student : Person
    {
        private static int _counter;
        public DateTime DateOfBirth { get; set; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string email, string phoneNumber)
        {
            Id = _counter++;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }

}

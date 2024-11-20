namespace ASP.Net_Core_MVC.Models
{
    public class Teacher : Person
    {
        private static int _counter;
        public Teacher(string firstName, string lastName,string email, string phoneNumber)
        {
            Id = _counter++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}

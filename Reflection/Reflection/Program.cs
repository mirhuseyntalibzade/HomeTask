using Reflection.Models;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            Type userType = typeof(User);
            
            PropertyInfo idProperty = userType.GetProperty("_id", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo nameProperty = userType.GetProperty("_name", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo surNameProperty = userType.GetProperty("_surname", BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo ageProperty = userType.GetProperty("_age", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            MethodInfo getFullNameMethod = userType.GetMethod("GetFullName", BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo changeAgeMethod = userType.GetMethod("ChangeAge", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            
            idProperty.SetValue(user1, 0);
            nameProperty.SetValue(user1, "Batman");
            surNameProperty.SetValue(user1, "Batmanoğlu");
            ageProperty.SetValue(user1, 15);
            getFullNameMethod.Invoke(user1, null);
            changeAgeMethod.Invoke(user1, new object[] { 45 });

            Console.WriteLine(idProperty.GetValue(user1));
            Console.WriteLine(nameProperty.GetValue(user1));
            Console.WriteLine(surNameProperty.GetValue(user1));
            Console.WriteLine(ageProperty.GetValue(user1));
        }
    }
}

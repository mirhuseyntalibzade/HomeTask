namespace WeaponGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon rifle = new Weapon();
            Console.WriteLine(
                """
                0 - To get information
                1 - For Shoot method
                2 - For Fire method
                3 - For GetRemainBulletCount method
                4 - For Reload method
                5 - For ChangeFireMode method
                6 - For Exitting The Programme
                """
                );

            string answer = default;

            while (answer!="6")
            {
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "0":
                        Console.WriteLine(
                            $"""
                        Maximum ammo capacity: {rifle.MaxAmmoCapacity}
                        Current ammo: {rifle.CurrentAmmoCapacity}
                        Rifle mode: {rifle.Mode}
                        """
                            );
                        break;
                    case "1":
                        Console.WriteLine("Trying to shoot.");
                        rifle.Shoot();
                        break;
                    case "2":
                        Console.WriteLine("Trying to fire.");
                        rifle.Fire();
                        break;
                    case "3":
                        Console.WriteLine($"Amount of bullets to refill magazine: {rifle.GetRemainBulletCount()}");
                        break;
                    case "4":
                        Console.WriteLine("Reloading...");
                        rifle.Reload();
                        break;
                    case "5":
                        rifle.ChangeFireMode();
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Incorrect input. Please try again");
                        break;
                }
            }
            Console.WriteLine("The programme has ended. Goodbye.");
        }
    }
}

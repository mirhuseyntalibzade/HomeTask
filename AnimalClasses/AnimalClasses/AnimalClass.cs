namespace AnimalClasses
{
    public class Animal
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public void Eat()
        {
            Console.WriteLine("Able to eat");
        }
    }

    public class Dog : Animal
    {
        public bool HasTail { get; set; }

        public void Bark() {
            Console.WriteLine("Dogs are barking");
        }
    }

    public class Bear : Animal
    {
        public bool IsWild { get; set; }
    }

    public class Bird : Animal
    {
        public bool CanSwim { get; set; }
        public void Fly ()
        {
            Console.WriteLine("Fly");
        }
    }
}

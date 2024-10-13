namespace AnimalClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please choose an animal type: bear, dog, bird");
                string animalType = Console.ReadLine();

                Animal animal = null;

                if (animalType == "bear")
                {
                    animal = CreateBear();
                }
                else if (animalType == "dog")
                {
                    animal = CreateDog();
                }
                else if (animalType == "bird")
                {
                    animal = CreateBird();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'bear', 'dog', or 'bird'.");
                    continue;
                }

                if (animal != null)
                {
                    Console.WriteLine("\nAnimal Details:");
                    Console.WriteLine($"Name: {animal.Name}");
                    Console.WriteLine($"Age: {animal.Age}");
                    animal.Eat();

                    if (animalType == "dog")
                    {
                        Dog dog = new Dog(); 
                        Console.WriteLine($"Has Tail: {dog.HasTail}");
                        dog.Bark();
                    }
                    else if (animalType == "bear")
                    {
                        Bear bear = new Bear();
                        Console.WriteLine($"Is Wild: {bear.IsWild}");
                    }
                    else if (animalType == "bird")
                    {
                        Bird bird = new Bird();
                        Console.WriteLine($"Can Swim: {bird.CanSwim}");
                        bird.Fly();
                    }

                    break;
                }
            }
        }

        static Dog CreateDog()
        {
            Console.WriteLine("What is your doggy's name?");
            string nameOfDog = Console.ReadLine();

            Console.WriteLine($"Great! Now what is the age of {nameOfDog}?");
            byte ageOfDog = byte.Parse(Console.ReadLine());

            Console.WriteLine("Does your dog have a tail? (yes/no)");
            bool hasTail = Console.ReadLine() == "yes";

            return new Dog { Name = nameOfDog, Age = ageOfDog, HasTail = hasTail };
        }
        static Bird CreateBird()
        {
            Console.WriteLine("What is your bird's name?");
            string nameOfBird = Console.ReadLine();

            Console.WriteLine($"Great! Now what is the age of {nameOfBird}?");
            byte ageOfBird = byte.Parse(Console.ReadLine());

            Console.WriteLine("Can it swim? (yes/no)");
            bool canSwim = Console.ReadLine() == "yes";

            return new Bird { Name = nameOfBird, Age = ageOfBird, CanSwim = canSwim };
        }
        static Bear CreateBear()
        {
            Console.WriteLine("What is your bear's name?");
            string nameOfBear = Console.ReadLine();

            Console.WriteLine($"Great! Now what is the age of {nameOfBear}?");
            byte ageOfBear = byte.Parse(Console.ReadLine());

            Console.WriteLine("Is it wild? (yes/no)");
            bool isWild = Console.ReadLine() == "yes";

            return new Bear { Name = nameOfBear, Age = ageOfBear, IsWild = isWild };
        }
    }
}


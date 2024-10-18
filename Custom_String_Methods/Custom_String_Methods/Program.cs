namespace Custom_String_Methods
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            CustomString myString = new CustomString("The cat is on top of the mat");

            string[] splitted = myString.CustomSplit('t');

            for (int i = 0; i < splitted.Length; i++)
            {
                Console.WriteLine(splitted[i]);
            }

            Console.WriteLine(myString.CustomReplace('m','p'));

            Console.WriteLine(myString.CustomLastIndexOf("a"));
        }
    }
}

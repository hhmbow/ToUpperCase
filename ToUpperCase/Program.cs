

namespace ToUpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your lower char");

            char input = Console.ReadKey().KeyChar;

            if (char.IsLower(input))
            {
                char uppercase = char.ToUpper(input);
                Console.WriteLine($"\n Your upper case letter: {uppercase}");
            }
            else
                Console.WriteLine("\n Invalid char");



        }
    }
}

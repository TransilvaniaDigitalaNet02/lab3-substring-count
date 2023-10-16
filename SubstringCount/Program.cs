namespace SubstringCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a text:");
            string text = Console.ReadLine() ?? string.Empty;

            Console.Write("Write the lookup substring:");
            string substring = Console.ReadLine() ?? string.Empty;

            int counter = StringHelper.CountOccurences(text, substring);

            Console.WriteLine($"{counter} instances of '{substring}' found");
        }
    }
}
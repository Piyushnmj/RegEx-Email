namespace RegExPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");

            Console.Write("\nEnter an EMail Address: ");
            string userInput = Console.ReadLine();

            Patterns objPattern = new Patterns();
            objPattern.ValidateEMail(userInput);
            Console.ReadLine();
        }
    }
}
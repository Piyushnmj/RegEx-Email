namespace RegExPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");

            Console.Write("Enter an EMail Address: ");
            Console.Write("(Format for EMail Address ==> abc.xyz@bridgelabz.co.in, where abc, bridgelabz and co are mandatory): ");
            string userInput = Console.ReadLine();

            Patterns objPattern = new Patterns();
            objPattern.ValidateEMail(userInput);
            Console.ReadLine();
        }
    }
}
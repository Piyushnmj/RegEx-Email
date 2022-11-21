namespace RegExPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expressions");

            Patterns objPattern = new Patterns();
            objPattern.ValidatePinCode("abc.xyz@bridgelabz.co.in");
            Console.ReadLine();
        }
    }
}
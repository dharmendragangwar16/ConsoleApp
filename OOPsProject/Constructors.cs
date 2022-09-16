namespace OOPsProject
{
    internal class Constructors
    {
        static Constructors()
        {
            Console.WriteLine("static constructor is called");
        }
        Constructors()
        {
            Console.WriteLine("non static constructo is caled");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called.");
            Constructors c1 = new Constructors();
            Constructors c2 = new Constructors();
            Constructors c3 = new Constructors();

            Console.ReadLine();

        }
    }
}

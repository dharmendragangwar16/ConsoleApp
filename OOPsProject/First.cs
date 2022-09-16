namespace OOPsProject
{
    internal class First
    {
        public int x = 100; //field (member of a class)


        static void Main()
        {
            First f1 = new First();
            First f2 = new First();

            Console.WriteLine(f1.x + "  " + f2.x);

            f1.x = 200;
            Console.WriteLine(f1.x + "  " + f2.x);
            f2.x = 300;
            Console.WriteLine(f1.x + "  " + f2.x);
            Console.WriteLine(  "-------------------------");

            First f3 = new First();
            First f4 = f3;

            Console.WriteLine(f3.x + "  " + f4.x);
            f3.x = 500;
            Console.WriteLine(f3.x + "  " + f4.x);
            f4 = null;
            Console.WriteLine(f3.x);
           // Console.WriteLine(f4.x);  signed as unused memory

            Console.ReadLine();
        }
    }
}

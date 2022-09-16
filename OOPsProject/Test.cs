namespace OOPsProject
{
    internal class Test
    {
        int x = 100; // non static 
        static int y = 200; //static
        static void Main()
        {
            Console.WriteLine(y + " static member");
            int z = 300;
            Console.WriteLine(z + " static member");

            Test t=new Test();
            Console.WriteLine(t.x + " non static member");
            Console.ReadLine();

        }


    }
}

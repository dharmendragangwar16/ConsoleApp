
using System.Security.Cryptography.X509Certificates;

namespace OOPsProject
{
    class Methods
    {
        int x = 300;
        static int y = 200;

        public void Add()
        {
            Console.WriteLine(x + y);
        }
        public static void Sub()
        {
            Methods m = new Methods();
            Console.WriteLine(m.x - y);
        }
    } class TestMethods
        {
            static void Main()
            {
                Methods obj = new Methods();
                obj.Add();    // Add is non static so calling with instance
                Methods.Sub();  //sub is static so calling with class name

                Console.WriteLine();
                Console.ReadLine();


            }
        }

    
}
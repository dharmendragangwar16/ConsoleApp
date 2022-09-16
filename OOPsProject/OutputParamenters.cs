using System.Collections.Concurrent;
using System.Data;

namespace OOPsProject
{
    internal class OutputParamenters
    {
        public  void Math1(int a,int b,out int c,out int d)
        {
            c = a + b;
            d = a * b;
        }
        public (int,int) Math2(int a,int b)
        {
            int c= a + b;   
            int d= a * b;
            return (c, d);
        }
        static void Main()
        {
            OutputParamenters  p= new OutputParamenters();
            int sum1,Product1;
            p.Math1(10, 12, out sum1,out Product1);
            Console.WriteLine("Sum of given numbers is : "  + sum1);
            Console.WriteLine( "Product of given numbers is : "+ Product1 );
            Console.WriteLine("-------------------------");

            p.Math1(10, 10,out int sum2,out int  Product2);
            Console.WriteLine("Sum of given numbers is : " + sum2);
            Console.WriteLine("Product of given numbers is : " + Product2);
            Console.WriteLine("------------------------------------------");

            (int sum3, int Product3) = p.Math2(15, 15);
            Console.WriteLine("Sum of given numbers is : " + sum3);
            Console.WriteLine("Product of given numbers is : " + Product3);
            Console.WriteLine("-----------------------------------------");

            var (sum4, Product4) = p.Math2(100, 120);
            Console.WriteLine("sum of given Numbers is : " + sum4);
            Console.WriteLine("Product of given Numbers is : " + Product4);
            Console.ReadLine();


        }
    }
}

namespace OOPsProject
{
    internal class Program
    {
        public void Test1() //static in behaviour
        {
            int x = 10;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine($"{x}*{i}={x*i}");
            }
        }
        public void Test2(int x,int y) //dynamic in behav
        {
            for(int i=0;i<y;i++)
            {
                Console.WriteLine($"{x}*{i}={x*i}");
            }
        }
        public string Test3() //static in behaviour
        {
            string s1 = "hello world";
            s1 = s1.ToUpper();
            return s1;
        }
        public string Test4(string s2) //dynamic in behaviour
        {
            s2 = s2.ToUpper();
            return s2;
        }
        static void Main()
        {
            Program p = new Program();
            p.Test1();
            Console.WriteLine("------------------------------");
            p.Test2(10,10);
           
            Console.WriteLine("----------------------------------------");


            string st = p.Test3();
            Console.WriteLine(st);
            Console.WriteLine();
            string st2= p.Test4("hello this is dk.");
            Console.WriteLine(st2);






        }

    }
}
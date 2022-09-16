

namespace OOPsProject
{
    internal class ProgramTest
    {
        public void CallMethod()
        {
            Program d = new Program();
            d.Test1();
            Console.WriteLine();
            d.Test2(5, 10);
            string st=d.Test3();
            Console.WriteLine(st);
            Console.WriteLine(d.Test4("hello dk"));
           
        }
        static void Main()
        {
            ProgramTest Tst=new ProgramTest();
            Tst.CallMethod();
        }
    }

}

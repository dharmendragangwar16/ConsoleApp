namespace OOPsProject
{
    internal class Class2:Class1
    {
        public Class2(int x):base(x)
        {
            Console.WriteLine("class 1 Constructor is called.");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3 is called.");
        }
        public void Test4()
        {
            Console.WriteLine("Method 4 is called.");
        }

        static void Main()
        {
            Class2 c = new Class2(10);
            c.Test1(); c.Test2();
            c.Test3(); c.Test4();

            Console.WriteLine(c.GetType());

            Console.ReadLine();
        }
    }
}

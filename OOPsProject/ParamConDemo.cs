namespace OOPsProject
{
    internal class ParamConDemo
    {
        public ParamConDemo(int i)
        {
            Console.WriteLine($"parameterized constructor is called. {i}");

        }
        static void Main()
        {
            ParamConDemo cd1 = new ParamConDemo(10);
            ParamConDemo cd2=new ParamConDemo(100);
            ParamConDemo dc3 = new ParamConDemo(200);

            Console.ReadLine();

        }
    }
}

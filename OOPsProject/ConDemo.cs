namespace OOPsProject
{
    internal class ConDemo
    {
        public ConDemo()
        {
            Console.WriteLine("hello constructor is called....!");
        }
        public void Demo()
        {
            Console.WriteLine("Method is caled");
        }
        static void Main()
        {
            ConDemo  cd1=new ConDemo();  
            ConDemo cd2=new ConDemo();
           

            cd1.Demo();  
            cd2.Demo();
            Console.WriteLine("-----------------");

            ConDemo cd3 = cd1;
            cd3.Demo();
            Console.WriteLine("----------------");
            ConDemo cd4=new ConDemo();
            Console.ReadLine();

        }
    }
}

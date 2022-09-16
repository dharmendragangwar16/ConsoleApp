namespace OOPsProject
{
    internal class OverloadCons
    {
        int i;bool b;

        public OverloadCons()
        {
            Console.WriteLine($"value of i is : {i} and value of b is : {b}");
        }
        public OverloadCons(int i, bool b)
        {
            this.i = i;
            this.b = b;
            Console.WriteLine($"value of i is : {i} and value of b is : {b}");
        }  
        public OverloadCons(int i)
        {
            this.i = i;
            Console.WriteLine($"value of i is {i} and value of b is : {b}");
        }
        public OverloadCons(bool b)
        {
            this.b = true;
            Console.WriteLine($"value of i is: {i} and value of b is : {b}");
        }
    }

    internal class TestOverloadCons
    {
        static void Main()
        {
            OverloadCons c1= new OverloadCons();
            OverloadCons c2= new OverloadCons(10,true);
            OverloadCons c3=new OverloadCons(20);
            OverloadCons c4 = new OverloadCons(true);

            Console.ReadLine();
                

        }
    }
}

namespace OOPsProject
{
    internal class Fields
    {
        int x;
        static int y;
        const float pi=3.14f;
        readonly bool flag;

        public Fields(int x, bool flag)
        {
            this.x = x;
            this.flag = true;
        }
        static void Main()
        {
            Console.WriteLine("static field y is : "+ y);
            Console.WriteLine("constactnt field field pi is : " + pi);

            y = 200;
            Console.WriteLine("modified value of static field y is : " + y);

            //  pi = 5.67f;   constant field can't be modified aagain after once declared

            Console.WriteLine("------------------------------------");

            //creating instances of the class

            Fields s1 = new Fields(100,true);
            Fields s2 = new Fields(150,false);

            Console.WriteLine("Non statc fields : " + (s1.x + " "+ s2.x));

            Console.WriteLine("Readonly fields : " + (s1.flag + " " + s2.flag));

            s1.x = 300; // static fields can be modified 
            s2.x = 400;
            Console.WriteLine("non staic fields  modified values :" + s1.x+" "+ s2.x);

            // s1.flag = false; readonly fields can't be modified once it initialized




            Console.ReadLine(); 
        }
    }
}

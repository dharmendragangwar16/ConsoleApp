namespace OOPsProject
{
    internal class Second
    {
        public int x;
        public Second(int x)
        {
            this.x = x;
        }
        static void Main()
        {
            Second s = new Second(200);

            Console.WriteLine(s.x);
            Console.ReadLine();
        }
    }
    
}

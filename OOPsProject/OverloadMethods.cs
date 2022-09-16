using System.Security.Cryptography;

namespace OOPsProject
{
    internal class OverloadMethods
    {
        public void Show()
        {
            Console.WriteLine("parameterless mehtod is called.");
        }
        public void Show(int x)
        {
            Console.WriteLine("integer parameter method is called." + x);
        }
        public void Show(string s)
        {
            Console.WriteLine("string parameter methodis called." + s);
        }
        public void Show(int x,string s)
        {
            Console.WriteLine("integer, string parameter ,method is called."+x,s);
        }
        public void Show(string s,int x)
        {
            Console.WriteLine("string,integer parameter method is called."+s+x);
        }
        public void Show(int x,string s,int y)
        {
            Console.WriteLine("integer,string,integer parameter method is called."+x,s,y);
        }
        static void Main()
        {
            OverloadMethods m = new OverloadMethods();
            m.Show("hello world",20);
            Console.WriteLine();
        }

    }
}

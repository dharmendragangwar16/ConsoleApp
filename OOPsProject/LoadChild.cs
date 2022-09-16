namespace OOPsProject
{
    internal class LoadChild:LoadParent
    {   //method overloading
        public void Test(int i)
        {
            Console.WriteLine("child class test method is called.");
        }
        // method overriding
        public override void Show()
        {
            Console.WriteLine("Child class show method  is called.");
        }
        // method hiding or shadowing
        public  new void Display()
        {
            Console.WriteLine("Child class Display method is called.");
        }
        public void PDisplay()
        {
            base.Display();
        }
        public void PShow()
        {
            base.Show();
        }
        static void Main()
        {
            LoadChild c = new LoadChild();  
            c.Test();               // executing parent class test method
            c.Test(1);              // executing child class Test  method
            c.Show();               // executing child class Show  method (overriding )
            c.Display();            // executing child class Display method (hiding/shadowing)
            c.PShow();
            c.PDisplay();

            LoadParent p = c; // creating refrence of parent class by using child class instance
            p.Display();      // purely child member
           
            p.Show();   
            Console.ReadLine();
        }
    }
}

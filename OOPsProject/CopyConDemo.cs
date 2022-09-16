namespace OOPsProject
{
    internal class CopyConDemo
    {
        int id;
        string Name;
        double Salary;
        public CopyConDemo(int id)
        {
            this.id = id;
            this.Name = "Ramesh";
            this.Salary = 25000.00;

        }
        public CopyConDemo(CopyConDemo cd)
        {
            this.id = cd.id;
            this.Name = cd.Name;
            this.Salary= cd.Salary; 
        }
        public override string ToString()
        {
            return id + "\n" + Name+ "\n" + Salary+ "\n";
        }
        public void Display()
        {
            Console.WriteLine($"Id : {id} Name : {Name} Salary : {Salary}");
        }

        static void Main()
        {
            CopyConDemo cd1 = new CopyConDemo(1007);
            CopyConDemo cd2 = new CopyConDemo(cd1);
            cd1.Display();
            cd2.Display();
            cd1.Name = "Uday";
            cd1.Salary = 50000.00;
            cd1.Display();
            cd2.Salary = 75000.00;
            cd2.Display();

            Console.ReadLine();

        }

    }
}

namespace OOPsProject
{
    class Emp
    {
        public int Id;
        public string Name;
        public string Job;
        public double Salary;
        public bool Status;
    }
    class UserDefinedType
    {
        public Emp GetDetails(int Id)
        {
            Emp emp = new Emp();
            emp.Id=Id;
            emp.Name = "Raju";
            emp.Job = "Manager";
            emp.Salary = 50000.00;
            emp.Status = true;
            return emp;

        }
    static void Main()
        {
            Emp employee=new Emp();
            UserDefinedType udt = new UserDefinedType();
            Emp m= udt.GetDetails(1006);

            Console.WriteLine(m.Id + " " + m.Name +  " "+ m.Job + " " + m.Salary +  " " + m.Status);
            Console.WriteLine();


        }

    }
}
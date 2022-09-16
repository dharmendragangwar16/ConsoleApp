namespace OOPsProject
{
    internal class TestMatrix
    {
        static void Main()
        {
            //creating 4 intances of Matrix of  claass with diffrent values

            Matrix m1 = new Matrix(10, 11, 12, 13);
            Matrix m2 = new Matrix(10, 11, 12, 13);
            Matrix m3 = new Matrix(30, 31, 32, 33);
            Matrix m4 = new Matrix(40, 41, 42, 43);
            Matrix m5 = m1 + m2+m3+m4;
            Matrix m6 = m1 - m2;
            Matrix m7 = m1 *m3;
            Matrix m8 = m2 / m1;
           


            Console.WriteLine("m1+m2+m3+m4");
            Console.WriteLine(m5);
            Console.WriteLine();
            Console.WriteLine("m1-m2");
            Console.WriteLine(m6);
            Console.WriteLine();
            Console.WriteLine("m1*m3");
            Console.WriteLine(m7);
            Console.WriteLine();
            Console.WriteLine("m2/m1");
            Console.WriteLine(m8);
            Console.WriteLine("m1=m2");
            Console.WriteLine(m1==m2);

         /* Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
        */
            Console.ReadLine();
        }
    }
}

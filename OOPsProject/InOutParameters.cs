using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProject
{
    internal class InOutParameters
    {
        public void Factorial(ref uint f)
        {
            if(f==0 || f==1)
            {
                f = 1;
            }
            else
            {
                uint result = 1;
                for(uint i=2;i<=f;i++)
                {
                    result= result*i;   
                }
                f=result;
            }
        }
        static void Main()
        {
            InOutParameters obj=new InOutParameters();
            uint a = 5;
            Console.WriteLine("value of a before execution of program : " + a);
            obj.Factorial(ref a);
            Console.WriteLine("value of a after execution of program : " + a);
            Console.WriteLine();



        }
    }
}

namespace OOPsProject
{
    internal class Matrix
    {
        //Declaring attributes of the Matrix for a 2*2 Matrix
        int a, b, c, d;
        // initializing attributes of Matrix in constructor
        public Matrix(int a,int b,int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;

        }
        //overloading the ToString() inherited from Object class to return values of the Matrixin 2*2 format
        public override string ToString()
        {
            return a + " " + b + " " + "\n"+ c + " " + d + "\n";
        }
        //implementing the + operator so it can be used between two Matrix operands
        public static Matrix operator +(Matrix obj1,Matrix obj2)
        {
            Matrix obj=new Matrix(obj1.a +obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj2.d);
            return obj;

        }
        public static Matrix operator -(Matrix obj1,Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a-obj2.b,obj1.b-obj2.b,obj1.c-obj2.c,obj1.d-obj2.c);
            return obj;
        }
        public static Matrix operator *(Matrix obj1,Matrix obj2)
        {
            Matrix obj= new Matrix(obj1.a * obj2.a, obj1.b * obj2.b, obj1.c * obj2.c, obj1.d * obj2.d);
            return obj;
        }
        public static Matrix operator /(Matrix obj1,Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a / obj2.a, obj1.b / obj2.b, obj1.c / obj2.c, obj1.d / obj2.d);
            return obj;
        }
        public static bool operator ==(Matrix obj1,Matrix obj2)
        {
            if(obj1.a == obj2.a && obj1.b== obj2.b && obj1.c == obj2.c && obj1.d == obj2.d)
                return true;
            else
                return false;
        }
        public static bool operator !=(Matrix obj1,Matrix obj2)
        {
            if (obj1.a != obj2.a || obj1.b != obj2.b || obj1.c != obj2.c || obj1.d != obj2.d)
                return true;
            else
                return false;
        }
    }
}

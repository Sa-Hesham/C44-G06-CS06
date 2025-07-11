using System.ComponentModel;
using System.Reflection;
using System.Threading.Channels;

namespace Assignment
{
    internal class Program

    {

        #region Q1
        //static void Swap(int x, int y)
        //{

        //    int temb = x;
        //    x = y;
        //    y = temb;

        //}


        //static void Swap2(ref int x, ref int y)
        //{

        //    int temb = x;
        //    x = y;
        //    y = temb;

        //}

        #endregion

        static void Main(string[] args)
        {

            #region Q1




            //1 - Explain the difference between passing(Value type parameters)
            //by value and by reference then write a suitable c# example.



            //            1.Passing by Value(default)
            //A copy of the variable is passed to the method.

            //Changes inside the method do not affect the original variable.

            //Applies to value types like int, float, struct, etc.

            //2. Passing by Reference(ref or out)
            //The reference to the original variable is passed.

            //Changes inside the method affect the original variable.

            //Can be used with both value types and reference types.


            //int a = 5, b = 8;
            //Swap(a, b);
            //Console.WriteLine($"a : {a} , b : {b} after swap by value ");

            //Swap2(ref a,ref b);
            //Console.WriteLine($"a : {a} , b : {b} after swap by referance ");





            #endregion



        }
    }
}

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
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




        #region Q2
        //static int sum(int[] arr)
        //{
        //     int sum = 0;
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            sum += arr[i];
        //        }
        //    }
        //    return sum;
        //}



        //static void change(ref int[] arr) {

        //    arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        //}


        #endregion


        #region Q3

        //static void SumAndSub(int a,int b , out int sum ,out int sub)
        //{
        //    sum = a + b;
        //    sub = a - b;
        //}

        #endregion


        #region Q4

        //static int Sumnumberdigits(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {

        //        sum += number % 10;
        //        number /= 10;

        //    }

        //    return sum;
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


            #region Q2


            //2 - Explain the difference between passing(Reference type
            //parameters) by value and by reference then write a suitable c# example.

            //1.Passing Reference Type by Value(default)
            //A copy of the reference is passed.
            // the adress  of referance will passing  as argument 


            //2.Passing Reference Type by Reference(ref)
            //The actual reference itself is passed.
            // the refernce will passed as a [ alias name ]


            //int[]arr = { 1, 2, 3 };
            ////Console.WriteLine(sum(arr));

            //change(ref arr);
            //for (int i = 0; i < arr.Length; i++) {

            //    Console.WriteLine(arr[i]);

            //}

            #endregion






            #region Q3

            //    Write a c# Function that accept 4 parameters from user and
            //return result of summation and subtracting of two numbers

            //int a = 10, b = 3;
            //int sum;
            //int sub;
            //SumAndSub(10, 3, out sum, out sub);
            //Console.WriteLine($"sum = {sum}");
            //Console.WriteLine($"sub = {sub}");



            #endregion


            #region Q4

            //4 - Write a program in C# Sharp to create a function to calculate the sum of the
            //    individual digits of a given number.
            //    Output should be like
            //    Enter a number: 25
            //    The sum of the digits of the number 25 is: 7 


            //Console.Write("Enter number ");
            //int.TryParse(Console.ReadLine(), out int num);

            //Console.WriteLine(Sumnumberdigits(num));




            #endregion


        }
    }
}

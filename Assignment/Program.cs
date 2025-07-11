

using System.Reflection.Metadata;
using System.Text;
using System.Transactions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


        #region Q5

        //static bool Isprime (int num)
        //{
        //    if (num <= 1)
        //    {
        //        return false;

        //    }

        //    for (int i = 2; i < num / 2; i++)
        //    {

        //         if (num % i == 0)
        //        {
        //            return false;
        //        }


        //    }
        //    return true;
        //}   
        #endregion

        #region q6
        //static void MinAndmax(int[] arr , out int max, out int min)
        //{


        //    if(arr is not null)
        //    {
        //        max = arr[0];
        //        min = arr[0];
        //        for(int i = 1; i < arr.Length; i++)
        //        {
        //            if (arr[i] > max)
        //            {
        //                max = arr[i];
        //            }
        //            if (arr[i] < min) {

        //                min= arr[i];

        //            }

        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("array is empty ");
        //        min = 0;    
        //        max = 0;    
        //    }

        // }
        #endregion


        #region Q7

        //static int factorial(int n) 
        //{
        //    int result = 1;
        //for (int i = 1; i < n; i++)
        //    {

        //        result *= i;

        //    }

        //   return result;

        //}
        #endregion



        #region Q8

        static string ChangeChar(string input, int position, char newChar)
        {
            if (input is null || position < 0 || position >= input.Length)
            {
                Console.WriteLine("Invalid input or position.");
                return input = "";
            }

            StringBuilder sb = new StringBuilder(input);
            sb[position] = newChar;

            return sb.ToString();
        }
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

            #region Q5


            //5 - Create a function named "IsPrime", which receives an integer number
            //and retuns true if it is prime, or false if it is not:

            //Console.Write("Enter number ");
            //int.TryParse(Console.ReadLine(), out int num);

            //if (Isprime(num))
            //{
            //    Console.WriteLine(num + " is  prime ");
            //}
            //else
            //{
            //    Console.WriteLine(num + " is  not  prime ");

            //}





            #endregion


            #region Q6

            //6 - Create a function named MinMaxArray, to return the minimum and
            //maximum values stored in an array, using reference parameters 

            //Console.WriteLine("enter the array size ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] arr=new int[size];
            //for (int i = 0; i < arr.Length; i++) {
            //    Console.WriteLine($"enter element {i+1}");

            //Console.WriteLine(arr[i]);


            //}


            //MinAndmax(arr, out int max, out int min);
            //Console.WriteLine($"max value is :: {max}");
            //Console.WriteLine($"min value is :: {min}");




            #endregion


            #region Q7

            //7 - Create function to calculate the factorial of the number specified as
            //    parameter


            //Console.Write("enter number");
            //int.TryParse(Console.ReadLine(), out int n);


            //Console.WriteLine($"factorial is {factorial(n)}");


            #endregion


            #region Q8
           // string name = "hello";
           //string change= ChangeChar(name, 1, 'm');
           // Console.WriteLine(change);
            #endregion

        }
    }
}

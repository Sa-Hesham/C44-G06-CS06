namespace Demo
{
    internal class Program
    {

        #region Function Prototype and Calling


        static void Printsahpe()  // with out Parameter 
        {
            //for (int i = 0; i < 10; i++)
            //{

            //    Console.WriteLine("*_*");

            //}



        }


        static void Printsapes(int count, string shapes)
        {



            for (int i = 0; i < count; i++)
            {



                Console.WriteLine(shapes);

            }



        }



        #endregion


        #region ValueType Parameter


        ////1. Passing By Value
        ////static void SWAP(int X, int Y) /*SWAP(3, 5)*/
        ////{
        ////    Console.WriteLine("====== SWAPING ======");
        ////    int Temp = X; // 3
        ////    X = Y; // 5
        ////   Y = Temp; // 3
        ////}

        // 2. Passing By Ref


        /// static void SWAP(ref int X, ref int Y) /*SWAP(A, B)*/
        /// {
        ///     Console.WriteLine("====== SWAPING ======");
        ///     int Temp = X; // 3
        ///     X = Y; // 5
        ///     Y = Temp; // 3
        /// }
        #endregion




        #region ReferenceType Parameters

        // 1. Passing By Value
        /// static int SumOfArray(int[] Arr) /* Arr = Numbers = [1, 2, 3]*/
        /// {
        ///     int Result = 0;
        /// 
        ///     if (Arr?.Length > 0)
        ///     {
        ///         //Arr[0] = 100;
        ///         Arr = new int[] { 4, 5, 6 };
        ///         for (int i = 0; i < Arr.Length /*DeReferencing*/; i++)
        ///             Result += Arr[i];
        ///     }
        /// 
        ///     return Result; // 15
        /// }

        // 2. Passing By Ref
        /// static int SumOfArray(ref int[] Arr) /*Arr(Numbers) = [4, 5, 6]*/
        /// {
        ///     int Result = 0;
        /// 
        ///     if (Arr?.Length > 0)
        ///     {
        ///         //Arr[0] = 100;
        ///         Arr = new int[] { 4, 5, 6 };
        ///         for (int i = 0; i < Arr.Length /*DeReferencing*/; i++)
        ///             Result += Arr[i];
        ///     }
        /// 
        ///     return Result; // 15
        /// }


        #endregion




        #region Passing By Out

        #region Example 01

        static void SumMul(int X, int Y, out int Sum, out int Mul)
        {
            Sum = X + Y;
            Mul = X * Y;
        }

        #endregion


        #endregion



        #region Params Keyword

        /// int[] arrayOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// List<int> listOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// 
        /// int Result = SumOfNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9);
        /// Result = SumOfNumbers(arrayOfNumbers);
        /// Result = SumOfNumbers(listOfNumbers);
        /// 
        /// Console.WriteLine($"Sum Of Array = {Result}");
        /// 
        /// // Console.WriteLine("", 20, 20.0M, 40.0M, "Hi", true, 'A');


        #endregion




        static void Main(string[] args)
        {

            // Printsahpe();

            //Printsapes(10, "%_%");                              // passing by order
            //Printsapes(shapes: "&^&", count: 5);            // passing parameter using Name 


            // int A = 3, B = 5;
            //Console.WriteLine($"A = {A}"); // 3
            // Console.WriteLine($"B = {B}"); // 5

            // SWAP(A, B);         // Passing By Value [Input Parameter] SWAP(3, 5);

            //Console.WriteLine($"A = {A}"); // 3
            //Console.WriteLine($"B = {B}"); // 5



            /// int A = 3, B = 5/*, SumResult, MulResult*/;
            /// 
            /// SumMul(A, B, out int SumResult, out int MulResult); // 3. Passing By Out [Output Parameter]
            /// 
            /// 
            /// Console.WriteLine($"Sum Result = {SumResult}");
            /// Console.WriteLine($"Mul Result = {MulResult}");
            /// 
            /// 
            /// Console.Write("Please Enter a Real Number: ");
            /// int.TryParse(Console.ReadLine(), out _); 





        }
    }
}

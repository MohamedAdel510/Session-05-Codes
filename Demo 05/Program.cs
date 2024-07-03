using System.Linq.Expressions;

namespace Demo_05
{

    // Class
    // Interface
    // Struct
    // Enum

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Gender sex { get; set; }
    }

    enum Gender
    {
        Male = 0, Female = 1, M = 0, F = 1
    }

    enum Greads
    {
        A, B, C, D, F
    }

    internal class Program
    {
        #region Passing by Out
        static void SumMul(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;
        }
        #endregion

        #region Function - params
        static int SumArray(int[] arr) 
        {
            int sum = 0;
            if(arr is not null)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static int SumArray02(params int[] arr)
        {
            int sum = 0;
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static int SumArray03(int x, int y = 10, params int[] arr) // parameter that have defualt value should be last parameter before params
        {
            int sum = 0;
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        #endregion


        static void Main(string[] args)
        {

            #region Array methods
            // there are to types of methods 
            // Class memeber methods, Object member methods

            // 1- Calss member methods
            //              0  1  2

            //int[] arr01 = { 2, 1, 3 };
            //                          //  0 1 2 3 4
            //int[] arr02 = new int[5]; // { , , , , }

            //// 1- Sort
            //Array.Sort(arr01); // arr01 becomes => {1, 2, 3};
            //for (int i = 0; i < arr01.Length; i++) 
            //{
            //    Console.WriteLine(arr01[i]);
            //}

            ////2- Copy
            //Array.Copy(arr01, arr02, 2);
            //foreach(int i in arr02)
            //{
            //    Console.WriteLine(i);
            //}

            ////3- ConstrainedCopy
            //// arr01 { 2, 1, 3 } arr02 { 0, 0, 0, 0, 0 }
            //Array.ConstrainedCopy(arr01, 1, arr02, 0, 2);
            //// arr01 {2, 1, 3} arr02 { 1, 3, 0, 0, 0 }
            //foreach (int i in arr02) {
            //    Console.WriteLine(i);
            //}

            ////4- CreateInstance
            //int[,,] arr04 = (int[,,])Array.CreateInstance(typeof(int), 3,3,3); 
            ////same as int[,,] arr04 = new int[3,3,3];

            //2- object member method

            //// CopyTo
            //  arr01.CopyTo(arr02, 1);
            ////{2, 1, 3}    {0, 2, 1, 3, 0}
            //foreach (int i in arr02) {
            //    Console.WriteLine(i);
            //}

            ////SetValue
            //arr02.SetValue(100, 4);
            //foreach (int i in arr02)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Passing by Out
            //int a = 5, b = 10, SumResualt, MulResualt;
            //SumMul(a, b, out SumResualt, out MulResualt);
            //Console.WriteLine(SumResualt);
            //Console.WriteLine(MulResualt);
            #endregion

            #region Functions - params
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(SumArray(numbers));

            //Console.WriteLine(SumArray02(1, 2, 3, 4, 5, 6, 7, 8, 9));

            ////                           x  y {                   }
            //Console.WriteLine(SumArray03(1, 2, 3, 4, 5, 6, 7, 8, 9)); // 42
            #endregion

            #region Exception handling and Protectivwe code

            #region Exception handling
            // Exeptions type:
            // 1- System excption
            // - foramt exception
            // - IndexOutOfRange
            // - InValidOperation
            // - NuiiReferenceException
            // - Arithmatic exception
            //   --> DivideByZero
            // 2- Application exceptiont

            //try
            //{
            //    int x, y, z;
            //    Console.Write("Enter X: ");
            //    x = int.Parse(Console.ReadLine());
            //    Console.Write("Enter Y: ");
            //    y = int.Parse(Console.ReadLine());
            //    z = x / y;
            //    int[] arr = { 1, 2, 3 };
            //    arr[100] = 101;
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region Protective code
            //try
            //{
            //    int x, y, z;
            //    do
            //    {
            //        Console.Write("Enter X: ");
            //    } while (!int.TryParse(Console.ReadLine(), out x));

            //    do
            //    {
            //        Console.Write("Enter Y: ");
            //    } while (!int.TryParse(Console.ReadLine(), out y) || y == 0);

            //    z = x / y;

            //    int[] arr = { 1, 2, 3 };
            //    if (arr?.Length > 100)
            //    {
            //        arr[100] = 101;
            //    }

            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #endregion

            #region Enum
            //Greads greads = Greads.A;
            //Console.WriteLine(greads);
            #endregion

            #region Struct
            //Point P1;
            //// Declare for object of type "Point" has attribute x, y
            //// clr will allocate and Intialize bytes at stack
            //P1.x = 3;
            //P1.y = 5;
            //Console.WriteLine(P1.x);
            //Console.WriteLine(P1.y);
            
            //// Calling parameterless Constructor
            //Point P2 = new Point();
            //Console.WriteLine(P2.x);
            //Console.WriteLine(P2.y);

            //// Calling parameteized Constructor
            //Point P3 = new Point(6 , 7);
            //Console.WriteLine(P3.x);
            //Console.WriteLine(P3.y);
            #endregion
        }
    }
}

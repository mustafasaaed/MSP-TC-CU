using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionFourDemo
{
    #region Loops
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("For Loop");
            //TryForLoop();
            //Console.WriteLine("==========================");

            //Console.WriteLine("While Loop");
            //TryWhileLoop();
            //Console.WriteLine("==========================");

            //Console.WriteLine("Switch");
            //TrySwitch();
            //Console.WriteLine("==========================");

            //Console.WriteLine("If");
            //TryIf();
            //Console.WriteLine("==========================");

            //Console.WriteLine("ForEach");
            //Console.WriteLine();
            //TryForEach();
            //Console.WriteLine("==========================");
            ForLastSess();

            Console.ReadKey();
        }

        private static void TryForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        //private static void TryWhileLoop()
        //{
        //    int i = 0;
        //    while (i < 10)
        //    {
        //        Console.WriteLine(i);
        //        i++;
        //    }
        //}

        //private static void TrySwitch()
        //{
        //    int i = 3;
        //    switch (i)
        //    {
        //        case 0:
        //            Console.WriteLine("I: " + 0);
        //            break;
        //        case 1:
        //            Console.WriteLine("I: " + 1);
        //            break;
        //        case 2:
        //            Console.WriteLine("I: " + 2);
        //            break;
        //        case 3:
        //            Console.WriteLine("I: " + 3);
        //            break;
        //        default:
        //            Console.WriteLine("Default case");
        //            break;
        //    }
        //}

        //private static void TryIf()
        //{
        //    int i = 10;

        //    if (i == 2)
        //    {
        //        Console.WriteLine("I: " + 2);
        //    }
        //    else if (i == 8)
        //    {
        //        Console.WriteLine("I: " + 8);
        //    }
        //    else
        //    {
        //        Console.WriteLine("I: " + 10);
        //    }
        //}

        //private static void TryForEach()
        //{
        //    string[] fruits = new string[3];

        //    fruits[0] = "Apple";
        //    fruits[1] = "Orange";
        //    fruits[2] = "banana";

        //    //string[] fruits = { "Apple", "Orange", "banana" };

        //    foreach (var fruit in fruits)
        //    {
        //        Console.WriteLine(fruit);
        //    }


        //    List<int> numbers = new List<int>();
        //    numbers.Add(0);
        //    numbers.Add(1);
        //    numbers.Add(2);

        //    Console.WriteLine();

        //    foreach (var num in numbers)
        //    {
        //        Console.WriteLine(num);
        //    }

        //}

        //// OR and 

        //private static void Operator()
        //{
        //    int i = 20;
        //    int y = 10;
        //    if (i == 20 && y == 10)
        //    {
        //        Console.WriteLine("True");
        //    }
        //    else
        //    {
        //        Console.WriteLine("False");
        //    }


        //    if (i == 20 || y == 15)
        //    {
        //        Console.WriteLine("True");
        //    }
        //}

        private static void ForLastSess()
        {

            int i = 0;
            int j = 0;
            for (int z = 0; z < 10; z++)
            {
                int a = i++;
                int b = ++j;

                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }





    }
}
    #endregion

    //#region Class

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person myPerson = new Person();
    //        myPerson.FirstName = "Reko";
    //        myPerson.LastName = "MSP";
    //        myPerson.Age = 17;


    //        myPerson.WhatIsMyName();

    //        var result = myPerson.Calculate(10, 20);
    //        Console.WriteLine(result);


    //        Console.ReadKey();
    //    }
    //    #endregion
    //}
//}

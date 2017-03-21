using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionFourDemo
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void WhatIsMyName()
        {
            Console.WriteLine("My Name is : {0} {1}", FirstName, LastName);
        }

        public int Calculate(int firstNum, int secondNum)
        {
            return firstNum + secondNum;

        }


    }
}

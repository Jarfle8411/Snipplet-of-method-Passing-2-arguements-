using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passing_2_Arguements
{
    class Simple_method_passing_two_arguements
    {
        static void Main(string[] args)
        {
            //initialize two varibles
            string name = "John Doe";
            int age = 32;

            HereCome2Arguements(name, age);
        }

        public static void HereCome2Arguements(string whoIsThis, int yearsLiving)
        {
            Console.WriteLine("Hello my name is {0} and my age is {1}", whoIsThis, yearsLiving);

        }

    }
}

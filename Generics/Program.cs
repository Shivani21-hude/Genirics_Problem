using System;
using System.Collections;
using System.Collections.Generic;
namespace Generics
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("To find maximum value betwwen 3 inputs using Generics \n");


            //Console.WriteLine("Maximnum int  value is : " + MaximumNumberCheck<int>.Maximum(12, 22, 20));
            //Console.WriteLine("Maximnum float value is : " + MaximumNumberCheck<float>.Maximum(44.2f,42.9f, 2.0f));
            //Console.WriteLine("Maximnum string value is : " + MaximumNumberCheck<string>.Maximum("Apple", "Peach", "Banana"));

            int[] intArray = { 22, 76, 34,89,45 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333","446","665" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
        }
    }
}
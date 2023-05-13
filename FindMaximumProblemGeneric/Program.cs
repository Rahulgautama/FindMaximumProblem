using System;

namespace FindMaximumProblemGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = "Apple";
            string secondNumber = "Peach";
            string thirdNumber = "Banana";
            FindMaximumFloatNumber findMaximumIntegerNumber = new FindMaximumFloatNumber();
            string maxString =findMaximumIntegerNumber.FindMaxStringNumber(firstNumber.Length,secondNumber.Length,thirdNumber.Length);

            Console.WriteLine(maxString);
        }
    }
}

using System;

namespace FindMaximumProblemGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNumber = 150.1f;
            float secondNumber = 160.2f;
            float thirdNumber = 170.3f;
            FindMaximumFloatNumber findMaximumIntegerNumber = new FindMaximumFloatNumber();
            float maxNumber=findMaximumIntegerNumber.FindMaxIntegerNumber(firstNumber,secondNumber,thirdNumber);

            Console.WriteLine(maxNumber);
        }
    }
}

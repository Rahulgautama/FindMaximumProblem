using System;

namespace FindMaximumProblemGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 150;
            int secondNumber = 167;
            int thirdNumber = 144;
            FindMaximumIntegerNumber findMaximumIntegerNumber = new FindMaximumIntegerNumber();
            int maxNumber=findMaximumIntegerNumber.FindMaxIntegerNumber(firstNumber,secondNumber,thirdNumber);

            Console.WriteLine(maxNumber);
        }
    }
}

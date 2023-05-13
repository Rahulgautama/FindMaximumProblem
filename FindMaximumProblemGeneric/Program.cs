using System;

namespace FindMaximumProblemGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 150;
            int secondNumber = 160;
            int thirdNumber = 170;
            FindMaximumIntegerNumber findMaximumIntegerNumber = new FindMaximumIntegerNumber();
            int maxNumber=findMaximumIntegerNumber.FindMaxIntegerNumber(firstNumber,secondNumber,thirdNumber);

            Console.WriteLine(maxNumber);
        }
    }
}

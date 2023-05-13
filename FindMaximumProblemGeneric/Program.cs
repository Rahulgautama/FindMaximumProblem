using System;

namespace FindMaximumProblemGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 20;
            int thirdNumber = 30;
           
            var maxNumber =FindMaxValue<int>.MaximumNumber(firstNumber,secondNumber,thirdNumber);

            Console.WriteLine(maxNumber);
        }
    }
}

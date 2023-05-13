using System;

namespace FindMaximumProblemGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 70;
            int secondNumber = 50;
            int thirdNumber = 60;
           
            var maxNumber =FindMaxValue<int>.MaximumNumber(firstNumber,secondNumber,thirdNumber);

            Console.WriteLine(maxNumber);
        }
    }
}

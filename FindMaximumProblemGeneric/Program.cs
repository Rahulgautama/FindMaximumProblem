using System;

namespace FindMaximumProblemGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 50;
            int secondNumber = 70;
            int thirdNumber = 60;
           
            var maxNumber =FindMaxValue<int>.MaximumNumber(firstNumber,secondNumber,thirdNumber);

            Console.WriteLine(maxNumber);
        }
    }
}

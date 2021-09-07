using System;
using System.Collections.Generic;

namespace CalculatorLib
{
    public class Calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public List<int> Numbers { get; set; }

        public int Add()
        {
            return Num1 + Num2;
        }

        public int Subtract()
        {
            return Num1 - Num2;
        }

        public int Multiply()
        {
            return Num1 * Num2;
        }

        public int Divide()
        {
            return Num2 > 0 ? Num1 / Num2 : throw new ArgumentException("Cannot Divide By Zero");
        }

        public int GetSumOfEveneNumbers()
        {
            int sum = 0;
            foreach(var num in Numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }

        public void AddToList(List<String> number)
        {
            foreach(var num in number)
            {
                Numbers.Add(int.Parse(num));
            }
        }
    }
}

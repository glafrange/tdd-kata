using System;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string num)
        {
            
            string[] numsSplit = num.Split(',');
            
            var sum = 0;
            foreach (string currentNum in numsSplit)
            {
                int temp;
                Int32.TryParse(currentNum, out temp);
                sum += temp;
            }
            
            return sum;
        }
    }
}

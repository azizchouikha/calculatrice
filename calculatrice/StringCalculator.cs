using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculatrice
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            
            string[] parts = numbers.Split(',');

            
            int sum = 0;

            
            for (int i = 0; i < parts.Length; i++)
            {
                
                string currentNumberString = parts[i];
                int currentNumber;

                
                bool isNumber = int.TryParse(currentNumberString, out currentNumber);

                
                if (isNumber)
                {
                    sum += currentNumber;
                }
                
                else
                {
                    continue;
                }
            }

            return sum;
        }
    }
}



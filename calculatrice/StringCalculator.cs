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

            foreach (string part in parts)
            {
                
                string trimmedPart = part.Trim();

                try
                {
                    
                    int currentNumber = int.Parse(trimmedPart);
                    sum += currentNumber;
                }
                catch (FormatException)
                {
                    
                    throw new FormatException($"La partie '{trimmedPart}' n'est pas un nombre valide.");
                }
            }

            return sum;
        }
    }
}






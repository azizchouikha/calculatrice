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

            var parts = numbers.Split(',');
            var negativeNumbers = new List<string>();
            int sum = 0;

            foreach (var part in parts)
            {
                var trimmedPart = part.Trim();
                if (int.TryParse(trimmedPart, out int currentNumber))
                {
                    if (currentNumber < 0)
                    {
                        
                        negativeNumbers.Add(trimmedPart);
                    }
                    else
                    {
                        sum += currentNumber;
                    }
                }
                else
                {
                    throw new FormatException($"La partie '{trimmedPart}' n'est pas un nombre valide.");
                }
            }

            if (negativeNumbers.Any())
            {
           
                throw new ArgumentException($"Nombres négatifs non autorisés: {string.Join(", ", negativeNumbers)}");
            }

            return sum;
        }
    }
}







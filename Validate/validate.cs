using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validate
{
    public class Validate
    {
        public static int ValidateNumber(string number)

        {
            //XmlConfigurator.Configure();
            //Regex match = Regex.Match(number,)
            int count = 0;
            do
            {

                Match match = Regex.Match(number, @"[0-9]+");
                if (match.Success && Convert.ToInt32(number) >= 0)
                    //if (Convert.ToInt32(number) >= 0)
                    return Convert.ToInt32(number);
                else
                {
                    //logger.Error(" wrong Input entered by user ");
                    Console.WriteLine("Please try again");
                    number = Console.ReadLine();
                }
                count++;
            } while (count < 5);
            throw new Exception("Number Format Exception More than 5 times");
        }
    }
}

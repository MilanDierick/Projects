using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class AftellenClass
    {
        List<int> Numbers = new List<int>();
        decimal Result = 0;
        decimal BaseNumber;
        bool BaseNumberIsEntered = false;

        public bool RequestInput()
        {
            try
            {
                
                if (BaseNumberIsEntered == false)
                {
                    Console.WriteLine("Please enter a number to subtract from.");
                    BaseNumber = int.Parse(Console.ReadLine());
                    BaseNumberIsEntered = true;
                    return true;
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                    Numbers.Add(int.Parse(Console.ReadLine()));
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        //TODO: implement boolean return values
        public void Calculate()
        {
            foreach (int number in Numbers)
            {
                Result = BaseNumber - number;
                BaseNumber = Result;
            }

            Console.WriteLine("The result is: " + Result);
        }
    }
}

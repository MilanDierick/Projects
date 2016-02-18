using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class OptellenClass
    {
        List<int> Numbers = new List<int>();
        int Result;

        public bool RequestInput()
        {
            try
            {
                Console.WriteLine("Please enter a number.");
                Numbers.Add(int.Parse(Console.ReadLine()));
                return true;
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
                Result = Result + number;
            }

            Console.WriteLine("The result is: " + Result);
        }
    }
}

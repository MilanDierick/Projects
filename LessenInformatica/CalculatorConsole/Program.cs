using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            OptellenClass Optellen = new OptellenClass();
            AftellenClass Aftrekken = new AftellenClass();
            VermenigvuldigenClass Vermenigvuldigen = new VermenigvuldigenClass();
            DelenClass Delen = new DelenClass();

            string Input;
            bool Continue = true;

            while (Continue == true)
            {

                Console.WriteLine("Wich calculation do you want to do? \nEnter the corresponding number.\n");
                Console.WriteLine("1. Optellen \n2. Aftrekken \n3. Vermenigvuldigen \n4. Delen \n");
                Input = Console.ReadLine();

                switch (Input)
                {
                    case "1":
                        Optellen.RequestInput();
                        Optellen.RequestInput();

                        Optellen.Calculate();

                        break;
                    case "2":
                        Aftrekken.RequestInput();
                        Aftrekken.RequestInput();

                        Aftrekken.Calculate();

                        break;
                    case "3":
                        Vermenigvuldigen.RequestInput();
                        Vermenigvuldigen.RequestInput();

                        Vermenigvuldigen.Calculate();

                        break;
                    case "4":
                        Delen.RequestInput();
                        Delen.RequestInput();

                        Delen.Calculate();

                        break;

                    default:
                        break;
                }

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Do you want to do another calculation? (Y/N)\n");
                string Response = Console.ReadLine();

                switch (Response)
                {
                    case "Y":
                        Continue = true;
                        break;
                    case "y":
                        Continue = true;
                        break;
                    case "N":
                        Continue = false;
                        break;
                    case "n":
                        Continue = false;
                        break;
                    default:
                        Continue = false;
                        break;
                }

                Console.Clear();
            }
        }
    }
}

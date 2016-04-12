using GameEngine_Primary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant_Worlds_First_Chapter
{
    [Serializable]
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            SystemCore.Setup(false);
            while (!SystemCore.Exit && SystemCore.IS_OK == true)
            {
                SystemCore.Handler.GetInput(true);
            }
        }
    }
}

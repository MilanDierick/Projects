using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_Primary
{
    static public class SystemCore
    {
        // Current Objects used by SystemCore
        public static Map Map;
        public static Handler Handler;
        public static Player HumanPlayer;

        static public bool Exit;
        static public bool IS_OK = false;

        // Needed to start the whole application!
        static public bool Setup(bool _Exit = false)
        {
            Exit = _Exit;
            Map = new Map();
            HumanPlayer = new Player(true, Map.LocationList[0]);
            Handler = new Handler(HumanPlayer, Map);
            IS_OK = true;
            return true;
        }
    }
}

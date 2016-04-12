using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_Primary
{
    [Serializable]
    public class Player
    {
        private Map Map = SystemCore.Map;

        public List<Item> Inventory = new List<Item>();

        public Location Location;

        public bool IsHuman;

        public string Identifier;

        public int TotalXP;
        public int Kills;
        public int Deaths;
        public int BattlesWon;
        public int BattlesLost;
        
        public Player(bool IsHuman, Location _Location, string _Identifier = null)
        {
            TotalXP = 0;
            Kills = 0;
            Deaths = 0;
            BattlesWon = 0;
            BattlesLost = 0;
            Location = _Location;

            if (IsHuman)
            {
                Identifier = "Human Player";
            }
            else
            {
                Identifier = _Identifier;
            }
        }
    }
}

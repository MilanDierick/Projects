using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        public int Health { get; set; }
        public int Shields { get; set; }
        public int Crew { get; set; }

        public int MAXHEALTH { get; }
        public int MAXSHIELDS { get; }
        public int MAXCREW { get; }

        public Player(int MaxHealth, int MaxShields, int MaxCrew)
        {
            MAXHEALTH = MaxHealth;
            MAXSHIELDS = MaxShields;
            MAXCREW = MaxCrew;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_Primary
{
    public class Stage
    {
        // Make sure each kind of stage has his own description and it gets displayed propertly by the handler.
        public List<Player> EnemyList = new List<Player>();
        public List<Player> FriendlyList = new List<Player>();

        public Player ShopKeeper;

        public Location CurrentStageLocation;

        public string description;

        private State CurrentStageState = State.Friendly;

        private int StageLevel;

        private enum State
        {
            Hostile, Friendly, ShopZone
        }

        public Stage(int _StageLevel)
        {
            ShopKeeper = new Player(false, CurrentStageLocation, "ShopKeeper");

            if (_StageLevel == 0)
            {
                StageLevel = _StageLevel;
                description = "Hostile stage.";
                CurrentStageState = State.Hostile;
                EnemyList.Add(new Player(false, CurrentStageLocation, "enemy1"));
                EnemyList.Add(new Player(false, CurrentStageLocation, "enemy2"));
            }
            else if (_StageLevel == 1)
            {
                StageLevel = _StageLevel;
                description = "Friendly stage.";
                CurrentStageState = State.Friendly;
                FriendlyList.Add(new Player(false, CurrentStageLocation, "friendly1"));
                FriendlyList.Add(new Player(false, CurrentStageLocation, "friendly2"));
            }
            else if (_StageLevel == 2)
            {
                StageLevel = _StageLevel;
                description = "Shopping stage.";
                CurrentStageState = State.ShopZone;
                ShopKeeper = new Player(false, CurrentStageLocation, "ShopKeeper");
            }
        }
    }
}

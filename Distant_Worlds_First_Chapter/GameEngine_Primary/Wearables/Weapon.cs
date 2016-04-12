using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_Primary
{
    public class Weapon : Item
    {
        public int Damage;
        public int Durability;

        public Weapon(int _ID, string _description, int _Damage, int _Durability) : base(_ID, _description)
        {
            Damage = _Damage;
            Durability = _Durability;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_Primary
{
    public class Item
    {
        public int ID;
        public string description;

        public Item(int _ID, string _description)
        {
            ID = _ID;
            description = _description;
        }
    }
}

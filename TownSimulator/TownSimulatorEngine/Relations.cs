using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownSimulatorEngine
{
    public class Relations
    {
        public class Husband
        {
            string HumanID;

            Husband(string _HumanID)
            {
                HumanID = _HumanID;
            }
        }

        public class Wife
        {
            string HumanID;

            Wife(string _HumanID)
            {
                HumanID = _HumanID;
            }
        }

        public class Child
        {
            string HumanID;

            Child(string _HumanID)
            {
                HumanID = _HumanID;
            }
        }

    }
}

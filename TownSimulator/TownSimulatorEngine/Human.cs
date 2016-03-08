using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownSimulatorEngine
{
    public class HumanData
    {
        
    }

    public class Human
    {
        List<Male> MaleList = new List<Male>();
        public class Male
        {
            public string Name;
            public string FullName;
            public int Age;
            public int HumanID;

            Relations.Wife Wife;
            List<Relations.Child> Childs = new List<Relations.Child>();

            /// <summary>
            /// Male constructor
            /// </summary>
            /// <param Name of male="_Name"></param>
            /// <param Full name of male="_FullName"></param>
            /// <param Age of male="_Age"></param>
            /// <param Unique ID of male="_HumanID"></param>
            Male(string _Name, string _FullName, int _Age, int _HumanID)
            {
                Name = _Name;
                FullName = _FullName;
                Age = _Age;
                HumanID = _HumanID;
            }
        }

        public class Female
        {
            public string Name;
            public string FullName;
            public int Age;
            public int HumanID;

            Relations.Wife Male;
            List<Relations.Child> Childs = new List<Relations.Child>();

            /// <summary>
            /// Female constructor
            /// </summary>
            /// <param Name of female="_Name"></param>
            /// <param Full name of female="_FullName"></param>
            /// <param Age of female="_Age"></param>
            /// <param Unique ID of female="_HumanID"></param>
            Female(string _Name, string _FullName, int _Age, int _HumanID)
            {
                Name = _Name;
                FullName = _FullName;
                Age = _Age;
                HumanID = _HumanID;
            }
        }

        /// <summary>
        /// Function for searching a human by given ID
        /// </summary>
        /// <param name="_HumanID"></param>
        /// <returns></returns>
        public Male GetHumanInstance(int _HumanID)
        {
            foreach (Male male in MaleList)
            {
                if (male.HumanID == _HumanID)
                {
                    return male;
                }
            }
            return null;
        }
    }
}

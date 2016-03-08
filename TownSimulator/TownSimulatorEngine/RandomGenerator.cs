using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownSimulatorEngine
{
    public class RandomGenerator
    {
        public double GenerateRandomNumber(int _MaxValue, int _MinValue = 0)
        {
            Random random = new Random();
            double RandomValue = random.NextDouble();
            return RandomValue;
        }
    }
}

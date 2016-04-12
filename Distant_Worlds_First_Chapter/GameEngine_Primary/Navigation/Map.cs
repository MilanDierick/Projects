using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_Primary
{
    public class Map
    {
        // List to store all the current locations
        public List<Location> LocationList = new List<Location>();

        // Constructor for the map class
        public Map()
        {
            GenerateRandomMap(10, 10);
        }

        private bool GenerateRandomMap(int _MapWidth, int _MapHeight, Random _Random = null)
        {
            int HostileLocationCount = 0;
            int FriendlyLocationCount = 0;
            int ShopZoneCount = 0;

            Random Random;
            if (_Random != null)
            {
                Console.WriteLine("Using predefined Random Generator from parameters.");
                Random = _Random;
            }
            else
            {
                Console.WriteLine("No Random Generator was passed from parameters, creating new...");
                Random = new Random();
            }
            for (int x = 0; x < _MapWidth; x++)
            {
                for (int y = 0; y < _MapHeight; y++)
                {
                    int RandomValue = Random.Next(0, 100);
                    Location _Location = new Location(x, y);

                    if (RandomValue < 10)
                    {
                        _Location.SetupLocation(new Stage(2));
                        ShopZoneCount++;
                    }
                    else if (RandomValue >= 10 && RandomValue < 80)
                    {
                        _Location.SetupLocation(new Stage(0));
                        HostileLocationCount++;
                    }
                    else if (RandomValue >= 80 && RandomValue < 100)
                    {
                        _Location.SetupLocation(new Stage(1));
                        FriendlyLocationCount++;
                    }
                    LocationList.Add(_Location);
                }
            }
            Console.WriteLine("Total amount of Locations: " + LocationList.Count);
            Console.WriteLine("Amount of Hostile Locations: " + HostileLocationCount);
            Console.WriteLine("Amount of Friendly Locations: " + FriendlyLocationCount);
            Console.WriteLine("Amount of Shopping Locations: " + ShopZoneCount);
            return true;
        }
    }
}

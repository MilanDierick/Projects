using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_Primary
{
    public class Location
    {
        public string Description;

        public Stage Stage;

        public int xpos;
        public int ypos;

        public Location(int _xpos, int _ypos, string _Description = "This is a default description for a Location.")
        {
            Description = _Description;
            xpos = _xpos;
            ypos = _ypos;
        }

        public void SetupLocation(Stage _Stage)
        {
            if (Stage == null)
            {
                Stage = _Stage;
            }
            else
            {
                Console.WriteLine("Location is already setup, this is not supposed to happen, investigate!");
            }
        }
    }
}

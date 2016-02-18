namespace Out_There_Omega_Edition_Private
{
    public class PlanetClass
    {
        enum ObjectType
        {
            
        }


        public float size;
        public string description;
        public int mineralAmount;
        public int fuelAmount;
    }

    class Earth: PlanetClass
    {
        Earth()
        {
            size = 1f;
            description = "";
            mineralAmount = 1000;
            fuelAmount = 1000;
        }
    }

    class Mars: PlanetClass
    {
        Mars()
        {
            size = 0.25f;
            description = "";
            mineralAmount = 2000;
            fuelAmount = 200;
        }
    }







}



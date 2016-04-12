using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine_Primary
{
    public class Handler
    {
        private Map Map;
        private Player HumanPlayer;
        private string Input;

        public Handler(Player _HumanPlayer, Map _Map)
        {
            HumanPlayer = _HumanPlayer;
            Map = _Map;
        }
        
        // Get input from user and process it if 'AutoProcess' is set to true
        public bool GetInput(bool _AutoProcess = true)
        {
            Input = Console.ReadLine();

            if (_AutoProcess)
            {
                ProcessInput();
            }
            return true;
        }

        public bool ProcessInput()
        {
            switch (Input)
            {
                case "":
                    Console.Clear();
                    Console.WriteLine("Nothing needs to be written.");
                    break;
                case "test":
                    Console.Clear();
                    Console.WriteLine("We are testing the program now.\n");
                    break;
                case "exit":
                    Console.Clear();
                    Console.WriteLine("Exitting now...\n");
                    SystemCore.Exit = true;
                    break;
                case "clear":
                    Console.Clear();
                    break;
                case "list locations":
                    Console.Clear();
                    foreach (Location location in Map.LocationList)
                    {
                        Console.WriteLine(location.Stage.description);
                        Console.WriteLine(location.xpos);
                        Console.WriteLine(location.ypos);
                    }
                break;
                case "list inventory":
                    Console.Clear();
                    if (HumanPlayer.Inventory.Count() == 0)
                    {
                        Console.WriteLine("Your inventory is empty!");
                    }
                    else
                    {
                        for (int i = 0; i < HumanPlayer.Inventory.Count(); i++)
                        {
                            Console.WriteLine(HumanPlayer.Inventory[i].description + " is stored at slot " + (i + 1));
                        }
                    }

                    break;
                case "list enemy's":
                    if (HumanPlayer.Location.Stage.EnemyList.Count() == 0)
                    {
                        Console.WriteLine("There are no enemy's in this location!");
                    }
                    else
                    {
                        foreach (Player enemy in HumanPlayer.Location.Stage.EnemyList)
                        {
                            Console.WriteLine(enemy.Identifier);
                        }
                    }
                    break;
                case "list friendly's":
                    if (HumanPlayer.Location.Stage.FriendlyList.Count() == 0)
                    {
                        Console.WriteLine("There are no friendly's in this location!");
                    }
                    else
                    {
                        foreach (Player friendly in HumanPlayer.Location.Stage.FriendlyList)
                        {
                            Console.WriteLine(friendly.Identifier);
                        }
                    }
                    break;
                case "list shopkeeper":
                    if (HumanPlayer.Location.Stage.ShopKeeper == null)
                    {
                        Console.WriteLine("There is no shop in this location!");
                    }
                    else
                    {
                        Console.WriteLine(HumanPlayer.Location.Stage.ShopKeeper);
                    }
                    break;
                case "add weapon":
                    if (HumanPlayer.Inventory.Count() == 10)
                    {
                        Console.WriteLine("Your inventory is full!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Weapon added!");
                        HumanPlayer.Inventory.Add(new Weapon(001, "Laser", 10, 5));
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Unrecognized command.\n");
                    break;
            }

            return true;
        }
    }
}

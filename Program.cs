using System;

namespace NavallBatlle4
{
    class Program
    {
        static void Main(string[] args)
        {
            NameInput();
            Field map1 = new Field();
            map1.ShowMap(map1.MapCreation());
            Console.WriteLine("Please choose your ship: submarine, destroyer, cruiser, battleship.");
            Ship one = new Ship(Ship.ShipName.submarine);
            Console.WriteLine("Please enter coordinates for your ship:");
            int i = Convert.ToInt32(Console.ReadLine());
            int k= Convert.ToInt32(Console.ReadLine());




        }
        static void NameInput()
        {
            Console.WriteLine("Enter player name:");
            string name = Console.ReadLine();
        }
    }
}

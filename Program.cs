using System;

namespace NavallBatlle4
{
    class Program
    {
        static void Main(string[] args)
        {
            NameInput();
            Field map1 = new Field();
            //map1.ShowMap(map1.MapCreation());
            Console.WriteLine("Please input ship length");
            Ship one = new Ship();
            one.ShipLenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter coordinates of your ship and direction(r-right, d-down):");
            int i = Convert.ToInt32(Console.ReadLine());
            int k= Convert.ToInt32(Console.ReadLine());
            string direct = Console.ReadLine();
            one.ShipSet(i, k, direct, one, map1.MapCreation());
            map1.ShowMap(map1.MapCreation());





        }
        static void NameInput()
        {
            Console.WriteLine("Enter player name:");
            string name = Console.ReadLine();
        }
    }
}

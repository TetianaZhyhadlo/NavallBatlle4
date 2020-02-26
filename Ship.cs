using System;
using System.Collections.Generic;
using System.Text;

namespace NavallBatlle4
{
    public class Ship
    {

        public bool ShipAlive { get; set; }
        public int ShipLenght { get; set; }
        public void ShipSet(int a, int b, string direction, Ship one, int[,] myMap)
        {
            int count = 0;
            if (myMap[a, b] == 0 && direction == "r")
            {
                for (int i = b; i < b + one.ShipLenght; i++)
                {
                    if (myMap[a, i] == 0)
                    {
                        count++;
                    }

                }
                if (count == one.ShipLenght)
                {
                    for (int i = b; i < b + one.ShipLenght; i++)
                    {
                        myMap[a, i] = 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ship cannot be placed. Choose another coordinates or direction");
                }
                count = 0;
            }
            if (myMap[a, b] == 0 && direction == "d")
            {
                for (int i = a; i < a + one.ShipLenght; i++)
                {
                    if (myMap[i, b] == 0)
                    {
                        count++;
                    }

                }
                if (count == one.ShipLenght)
                {
                    for (int i = a; i < a + one.ShipLenght; i++)
                    {
                        myMap[i, b] = 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ship cannot be placed. Choose another coordinates or direction");
                }
                count = 0;
            }


        }

    }
        
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NavallBatlle4
{
    public class Field
    {
        int size;
        public int FieldSize
        {
            get
            {
                return size;
            }
            set
            {
                FieldSize = size;
            }
        }

        public int[,] MapCreation()
        {
            int s = 12;
            int[,] map = new int[s, s];
            for (int i = 0; i < s-1; i++)
            {
                for (int k = 0; k < s-1; k++)
                {
                    if (i != 0 && k == 0)
                        map[i, k] = i;
                    else if (i == 0 && k != 0)
                        map[i, k] = k;
                    else
                        map[i, k] = 0;

                }

            }
            return map;
        }
        public void ShowMap(int[,] myMap)
        {
            int s = 12;
            for (int i = 0; i < s-1; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < s-1; k++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\t|", ConsoleColor.DarkBlue);
                    Console.ResetColor();
                    if (k == 0 || i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"{myMap[i,k]}", ConsoleColor.Green);
                        Console.ResetColor();
                    }
                    if (myMap[i, k] == 1 && i!=0 && k!=0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("▲", ConsoleColor.Green);
                        Console.ResetColor();
                    }
                    else if (myMap[i, k] == 2 && i != 0 && k != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("▼", ConsoleColor.Red);
                        Console.ResetColor();
                    }
                    else if (myMap[i, k] == -1 && i != 0 && k != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("—", ConsoleColor.Blue);
                        Console.ResetColor();
                    }
                    else if (myMap[i, k] == 0 && i != 0 && k != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("•", ConsoleColor.Blue);
                        Console.ResetColor();
                    }

                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\t|", ConsoleColor.DarkBlue);
                Console.ResetColor();
            }

        }
        public void ShipSet(int a, int b, string direction, Ship one, int[,] myMap)
        {
             int count=0;
             if(myMap[a,b]==0 && direction=="r")
             {
                for (int i = b; i < b + one.ShipLenght;i++)
                {
                    if(myMap[a,i]==0)
                    {
                        count++;
                    }

                }
                if(count==one.ShipLenght)
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

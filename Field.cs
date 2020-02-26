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
        
    }
}

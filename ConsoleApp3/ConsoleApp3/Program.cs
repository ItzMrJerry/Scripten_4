using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        //part 1
            enum Directions
            {
            north,
            south,
            east,
            west
            }
        static void Main(string[] args)
        {
            
            ChoseDirection();


            void ChoseDirection()
            {
                //part 2
                int chosenDirection = 0;

                Console.WriteLine("Chosen the directions");
                Console.WriteLine("0 North, 1 South, 2 East , 3 West");
                chosenDirection = int.Parse(Console.ReadLine());

                if (chosenDirection < 0 | chosenDirection > 3)
                {
                    ChoseDirection();
                    Console.Clear();
                }
                else
                {
                var playerDirection = (Directions)chosenDirection;
                    Console.WriteLine((Directions)chosenDirection);
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    ChoseDirection2();

                }
            }

            void ChoseDirection2()
            {
                string Direction;
                Console.WriteLine("Chosen the directions");
                Console.WriteLine("North, South, East , West");
                Direction = Console.ReadLine();

                if (Direction == Directions.north.ToString())
                {
                    Console.WriteLine("north");
                } 
                else if (Direction == Directions.south.ToString())
                {
                    Console.WriteLine("south");
                }
                else if (Direction == Directions.east.ToString())
                {
                    Console.WriteLine("east");
                }
                else if (Direction == Directions.west.ToString())
                {
                    Console.WriteLine("west");
                }
            }
        }
        


    }
}

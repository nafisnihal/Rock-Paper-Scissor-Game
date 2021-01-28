using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to RSP Game\n1.Rock\n2.Paper\n3.Scissors\nChoose your option:");
            int firstPlayer = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("You have selected: " + firstPlayer);
            if (firstPlayer == 1)
            {
                Console.WriteLine("You have selected Rock");
            }
            else if (firstPlayer == 2)
            {
                Console.WriteLine("You have selected Paper");
            }
            else if (firstPlayer == 3)
            {
                Console.WriteLine("You have selected Scissor");
            }

            Random r = new Random();
            int secondPlayer = r.Next(1, 3);
            if (secondPlayer == 1)
            {
                Console.WriteLine("Computer has selected Rock");
            }
            else if (secondPlayer == 2)
            {
                Console.WriteLine("Computer has selected Paper");
            }
            else if (secondPlayer == 3)
            {
                Console.WriteLine("Computer has selected Scissor");
            }

            if (firstPlayer == secondPlayer)
            {
                Console.WriteLine("Draw!");
            }else if (firstPlayer==1 && secondPlayer==2)
            {
                Console.WriteLine("Computer Won:(");
            }
            else if (firstPlayer == 1 && secondPlayer == 3)
            {
                Console.WriteLine("You Won!)");
            }
            else if (firstPlayer == 2 && secondPlayer == 1)
            {
                Console.WriteLine("You won!");
            }
            else if (firstPlayer == 2 && secondPlayer == 3)
            {
                Console.WriteLine("Computer Won:(");
            }
            else if (firstPlayer == 3 && secondPlayer == 1)
            {
                Console.WriteLine("Computer Won:(");
            }
            else if (firstPlayer == 3 && secondPlayer == 2)
            {
                Console.WriteLine("You won!");
            }

            Console.ReadLine();
        }
    }
}

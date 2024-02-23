using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_15
{
    class Puzzle15
    {
        static int[,] board;
        static int red;
        static int kolona;

        static void Main(string[] args)
        {
            Reshetka();
            Zavurti(100);
            Print();

            while (!AkoReshen())
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.UpArrow && red > 0)
                    Premesti(red - 1, kolona);
                else if (key.Key == ConsoleKey.DownArrow && red < 3)
                    Premesti(red + 1, kolona);
                else if (key.Key == ConsoleKey.LeftArrow && kolona > 0)
                    Premesti(red, kolona - 1);
                else if (key.Key == ConsoleKey.RightArrow && kolona < 3)
                    Premesti(red, kolona + 1);

                Print();
            }

            Console.WriteLine("Congratulations! You solved the puzzle!");
        }

        static void Reshetka()
        {
            board = new int[4, 4];
            int count = 1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    board[i, j] = count++;
                }
            }

            red = 3;
            kolona = 3;
            board[red, kolona] = 0;
        }

        static void Zavurti(int moves)
        {
            Random rnd = new Random();

            for (int i = 0; i < moves; i++)
            {
                int posoka = rnd.Next(4);

                if (posoka == 0 && red > 0)
                    Premesti(red - 1, kolona);
                else if (posoka == 1 && red < 3)
                    Premesti(red + 1, kolona);
                else if (posoka == 2 && kolona > 0)
                    Premesti(red, kolona - 1);
                else if (posoka == 3 && kolona < 3)
                    Premesti(red, kolona + 1);
            }
        }

        static void Premesti(int row, int col)
        {
            board[red, kolona] = board[row, col];
            board[row, col] = 0;
            red = row;
            kolona = col;
        }

        static bool AkoReshen()
        {
            int count = 1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] != count && !(i == 3 && j == 3))
                        return false;
                    count++;
                }
            }

            return true;
        }

        static void Print()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == 0)
                        Console.Write("    ");
                    else
                        Console.Write($"{board[i, j],4}");

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

}

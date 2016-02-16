using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4___Problem_4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            int[,] table = { {3, 4, 5, 6, 3},
                             {2, 1, 2, 1, 1},
                             {3, 2, 1, 4, 9},
                             {1, 0, 0, 1, 1},
                             {9, 2, 6, 4, 9} }; // declaration and initialization of table
            int[] lst = { 2, 1, 2, 3, 4 }; // declaration and initialization of list

            // print table
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write("{0,5} ", table[i, j]);
                    if (j == table.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();

            // print lst
            for (int i = 0; i < lst.Length; i++)
            {
                Console.Write("{0,5} ", lst[i]);
            }

            Console.WriteLine("\n");

            int[,] newTable = SubtractTableAndLst(table, lst); // declaration and initialization of new table that contains the result after subtraction
            
            // print the new table
            for (int i = 0; i < newTable.GetLength(0); i++)
            {
                for (int j = 0; j < newTable.GetLength(1); j++)
                {
                    Console.Write("{0,5} ", newTable[i, j]);
                    if (j == newTable.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();

            // declare a new table that holds the result after multiply method
            int[,] newTableMultiply = new int[table.GetLength(0), table.GetLength(1)];
            
            // call the method that multiply table and list
            MultiplyTableAndLst(table, lst, ref newTableMultiply);

            // print the new table
            for (int i = 0; i < newTableMultiply.GetLength(0); i++)
            {
                for (int j = 0; j < newTableMultiply.GetLength(1); j++)
                {
                    Console.Write("{0,5} ", newTableMultiply[i, j]);
                    if (j == newTableMultiply.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        // method that subtract table and lst
        static int[,] SubtractTableAndLst(int[,] table, int[] lst)
        {
            int[,] newTable = new int[table.GetLength(0), table.GetLength(1)];
            for (int i = 0; i < table.GetLength(0); ++i)
            {
                for (int j = 0; j < lst.Length; j++)
                {
                    newTable[i, j] = table[i, j] - lst[j];
                }
            }
            return newTable;
        }

        //method that multiply table and lst
        static void MultiplyTableAndLst(int[,] table, int[] lst, ref int[,] newTableMultiply)
        {
            for (int i = 0; i < table.GetLength(0); ++i)
            {
                for (int j = 0; j < lst.Length; j++)
                {
                    newTableMultiply[i, j] = table[i, j] * lst[j];
                }
            }
        }
    }
}

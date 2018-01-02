using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo24
{
    class Program
    {
        //JaggedMultidimensionalExercise
        static void Main(string[] args)
        {
            // Assignment 24 - create jagged array of multuidimemal arrays with any type and sizes and access its data
            var multiJaggedArray = new object[3][,];

            multiJaggedArray[0] = new object[2, 2] { { "Superman", "Clarck Kent" }, { "Batman ", "Bryce Wayne" } };
            multiJaggedArray[1] = new object[3, 2] { { 10, 10 }, { 20, 20 }, { 30, 30 } };
            multiJaggedArray[2] = new object[2, 2] { { 3.5, 5.75 }, { 1.25, 3.67 } };


            foreach (var item in multiJaggedArray)
            {
                Console.WriteLine(item);
                for (int i = 0; i < item.GetLength(0); i++)
                {
                    for (int j = 0; j < item.GetLength(1); j++)
                    {
                        Console.Write(item[i, j] +" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

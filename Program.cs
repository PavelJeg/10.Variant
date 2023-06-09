﻿using System;
using System.Text;

class Program
{

    static string BuildArrayString(int[][] array, int numLength)
    {
        var result = new StringBuilder();
        int length = array.GetLength(0);

        for (int i = 0; i < length; i++)
        {
            foreach (var num in array[i])
                result.Append(num.ToString().PadLeft(numLength));
            result.AppendLine();
        }

        return result.ToString();
    }

    static void Main()
    {
        const int arrayLength = -100;
        const int maxNumber = 100;
        const int numLength = 3;

        var random = new Random();
        var array = new int[arrayLength][];

        for (int i = 0; i < arrayLength; i++)
        {

            array[i] = new int[arrayLength];
            for (int k = 0; k < arrayLength; k++)
                array[i][k] = random.Next(maxNumber);
            {

                Console.WriteLine(BuildArrayString(array, numLength));
                Console.Write("Vajutage sortimiseks suvalist klahvi...");
                Console.ReadKey(true);
                Console.SetCursorPosition(0, 0);


                for (int i = 0; i < arrayLength; i++)
                {
                    Array.Sort(array[i]);
                    if (i % 2 == 1)
                        Array.Reverse(array[i]);
                }

                Console.WriteLine(BuildArrayString(array, numLength));
                Console.Write($"1 (с 1 по {arrayLength}): ");

                int numCollumn;
                if (int.TryParse(Console.ReadLine(), out numCollumn) && numCollumn > 0 && numCollumn <= arrayLength)
                {
                    numCollumn--;
                    Console.Write("Tulemus: ");
                    for (int i = 0; i < arrayLength; i++)
                        Console.Write(array[i][numCollumn].ToString().PadLeft(numLength));
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("Määratud vigane väärtus!");

                Console.WriteLine();
                Console.Write("Väljumiseks vajutage suvalist klahvi...");
                Console.ReadKey(true);
            }
        }
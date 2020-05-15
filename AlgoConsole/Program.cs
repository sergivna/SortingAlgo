﻿
using CalculateTimes;
using SortingTime;
using System;
using System.Collections.Generic;

namespace AlgoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<long> ls = new List<long>(new long[] {  2, 3, 4, 4, 2, 8, 10, 0 });
            int writeToFile = 0;

            while (writeToFile != 1 && writeToFile != 2)
            {
                Console.WriteLine("Do you want to create files?\n 1- Yes\n2- No ");
                try
                {
                    writeToFile = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Try again\n");
                }
            }

            List<Result> times = Sort.CalculateRealData();


            foreach (var item in times)
            {
                string info = item.Algo + "\nCount: " + item.Count + " Type:"
                                                 + item.Type + " AverageTime:" + item.AverageTime + "\n";

                Console.Write(info);

            }


            if (writeToFile == 1)
                WriteToFiles(times);

            Console.ReadKey();
        }

        static void WriteToFiles(List<Result> list)
        {
            // запись в файл
            using (FileStream fstream = new FileStream($"note.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты

                foreach (var item in list)
                {
                    string info = item.Algo + "\nCount: " + item.Count + " Type:"
                                                + item.Type + " AverageTime:" + item.AverageTime + "\n";

                    byte[] array = System.Text.Encoding.Default.GetBytes(info);
                    // запись массива байтов в файл
                    fstream.Write(array, 0, array.Length);
                }
            }

        }
    }
}

using System;

namespace ControlWork // Итоговая проверочная работа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string EnterArrayElement(int index)
            {
                string userString = "";
                Console.Write($"Введите {index} элемент массива и нажмите клавишу Enter: ");
                userString = Console.ReadLine();
                return userString;
            }

            void ControlWork()
            {
                string userString = "";
                Console.Write("Введите размер массива и нажмите клавишу Enter: ");
                userString = Console.ReadLine();
                int arraySize = Convert.ToInt32(userString);
                string[] ArrayInitial = new string[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    ArrayInitial[i] = EnterArrayElement(i);
                }
                Console.WriteLine($"Вы ввели массив из {arraySize} элементов:");
                for (int i = 0; i < arraySize; i++)
                {
                    Console.WriteLine(ArrayInitial[i]);
                }
            }

            ControlWork();

        }



        static void FillArray(int[,] Array, int minValue = 0, int maxValue = 99)
        {
            maxValue++;
            Random rnd = new Random();
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Array[i, j] = rnd.Next(minValue, maxValue);
                }
            }
        }

        static void FillArray(double[,] Array, double minValue = 0, double maxValue = 1)
        {
            Random rnd = new Random();
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Array[i, j] = minValue + rnd.NextDouble() * (maxValue - minValue);
                }
            }
        }

        static void PrintArray(int[,] Array)
        {
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{Array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void PrintArray(double[,] Array)
        {
            int rows = Array.GetLength(0);
            int columns = Array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{Array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
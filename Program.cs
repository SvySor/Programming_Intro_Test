using System;

namespace ControlWork // Итоговая проверочная работа
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Метод для ввода данных элементов строкового массива 

            string EnterArrayElement(int index)
            {
                string userString = "";
                Console.Write($"Введите {index} элемент массива: ");
                userString = Console.ReadLine();
                return userString;
            }

            void ControlWork()
            {
                // Ввод исходных данных

                string userString = "";
                Console.Write("Введите размер массива и нажмите клавишу Enter: ");
                userString = Console.ReadLine();
                int arraySize = Convert.ToInt32(userString);
                string[] ArrayInitial = new string[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    ArrayInitial[i] = EnterArrayElement(i);
                }
                Console.WriteLine();
                Console.WriteLine($"Вы ввели массив из {arraySize} элементов:");
                PrintArray(ArrayInitial);

                // Проверка длины каждого элемента и расчёт размера служебного массива

                Boolean[] ArrayControl = new Boolean[arraySize];
                int elementSizeLimit = 3;
                int counterNewArray = 0;
                for (int i = 0; i < arraySize; i++)
                {
                    if (ArrayInitial[i].Length <= elementSizeLimit)
                    {
                        ArrayControl[i] = true;
                        counterNewArray++;
                    }
                    else ArrayControl[i] = false;
                }

                // Создание и запись нового массива

                string[] ArrayResult = new string[counterNewArray];
                int j = 0;
                for (int i = 0; i < arraySize; i++)
                {
                    if (ArrayControl[i] == true)
                    {
                        ArrayResult[j] = ArrayInitial[i];
                        j++;
                    }
                }

                // Вывод на печать нового массива

                Console.WriteLine();
                Console.WriteLine($"Результирующий массив состоит из {counterNewArray} элементов:");
                PrintArray(ArrayResult);
            }

            ControlWork();


            static void PrintArray(string[] Array)
            {
                int rows = Array.GetLength(0);
                for (int i = 0; i < rows; i++)
                {
                    Console.Write($"{Array[i]}\t");
                }
            }
        }
    }
}
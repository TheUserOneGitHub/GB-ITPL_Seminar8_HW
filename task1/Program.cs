// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillAray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 6);
        }
    }
}

void SortArray(double[,] array, int m, int n)
{
    int count = 0;
    while (count < m * n)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                double num1 = array[i, j];
                double num2 = array[i, j + 1];

                if (array[i, j] > array[i, j + 1])
                {
                    array[i, j] = num2;
                    array[i, j + 1] = num1;
                }

            }
        }
        count++;
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} \t");
        }
        Console.WriteLine($"");
    }
    Console.WriteLine($"");
}





Console.WriteLine("Enter rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter columns number");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

FillAray(array);
PrintArray(array);
SortArray(array, m, n);
PrintArray(array);
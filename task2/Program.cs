// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillAray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintArray(double[,] array)
{
    Console.WriteLine($"The Array:");
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


void ArrayOfRowSums(double[,] array, double[] arrayRowsSums, double m)
{
    int count = 0;
    while (count < m)
    {
        int k = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            double sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i, j];
            }
            arrayRowsSums[k] = sum;
            k++;
            count++;
        }
    }
}

void PrintArrayofRowSums(double[] arrayRowsSums)
{
    Console.Write($"Sums of rows: ");
    for (int i = 0; i < arrayRowsSums.Length; i++)
    {
        Console.Write($"{arrayRowsSums[i]}, ");
    }
    Console.WriteLine($"");
}

void LowestSum(double[] arrayRowsSums)
{
    int rowTheLowestSum = 0;
    double min = arrayRowsSums[0];
    Console.Write($"The lowest sum is ");
    for (int i = 1; i < arrayRowsSums.Length; i++)
    {
        if (min > arrayRowsSums[i])
        {
            min = arrayRowsSums[i];
            rowTheLowestSum = i;
        }
        else
        {
            min = min;
        }
    }
    Console.Write($"{min}, it's row(s) number ");
    for (int i = 0; i < arrayRowsSums.Length; i++)
    {
        if (arrayRowsSums[i] == min)
        {
            Console.Write($"{i} (first row is row number 0) ");
        }
    }
}





Console.WriteLine("Enter rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter columns number");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
int k = m;
double[] arrayRowsSums = new double[k];

FillAray(array);
PrintArray(array);
ArrayOfRowSums(array, arrayRowsSums, m);
PrintArrayofRowSums(arrayRowsSums);
LowestSum(arrayRowsSums);
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillMatrix(double[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(-99, 100);
                int count = 1;
                while (count > 0)
                {
                    count = 0;
                    for (int p = 0; p < matrix.GetLength(0); p++)
                    {
                        for (int q = 0; q < matrix.GetLength(1); q++)
                        {
                            for (int r = 0; r < matrix.GetLength(2); r++)
                            {
                                if (p == i && q == j && r == k)
                                {
                                    // Console.WriteLine($"Equals arguments {matrix[i, j, k]}({i},{j},{k}) = {matrix[p, q, r]}({p},{q},{r})");
                                }
                                else if (matrix[p, q, r] == matrix[i, j, k])
                                {
                                    count++;
                                    // Console.Write($"{matrix[i, j, k]}({i},{j},{k}) = {matrix[p, q, r]}({p},{q},{r})");
                                    // Console.WriteLine($"");
                                    while (matrix[i, j, k] == matrix[p, q, r])
                                    {
                                        matrix[i, j, k] = new Random().Next(-99, 100);
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

    }
}

void PrintMatrix(double[,,] matrix)
{
    Console.Write($"The matrix: ");
    Console.WriteLine($"");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],4}({i},{j},{k}) \t");
            }
            Console.WriteLine($"");
        }
    }
}


Console.WriteLine("Enter number of first demension array length");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of second demension array length");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of third demension array length");
int l = Convert.ToInt32(Console.ReadLine());

double[,,] matrix = new double[m, n, l];

FillMatrix(matrix);
PrintMatrix(matrix);
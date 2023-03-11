// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillMatrixA(double[,] matrixA)
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            matrixA[i, j] = new Random().Next(-10,11);
        }
    }
}

void FillMatrixB(double[,] matrixB)
{
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixB[i, j] = new Random().Next(-10,11);
        }
    }
}

void PrintMatrixA(double[,] matrixA)
{
    Console.WriteLine($"matrix A:");
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            Console.Write($"{matrixA[i, j],3} \t");
        }
        Console.WriteLine($"");
    }
    Console.WriteLine($"");
}

void PrintMatrixB(double[,] matrixB)
{
    Console.WriteLine($"matrix B:");
    for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            Console.Write($"{matrixB[i, j],3} \t");
        }
        Console.WriteLine($"");
    }
    Console.WriteLine($"");
}

void Multiply(double[,] matrixA, double[,] matrixB, double[,] matrixC)
{
    int r =0;
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        int v = 0;
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            int s = 0;
            int t = 0;
            for (int count = 0; count < matrixA.GetLength(1); count++)
            {
               matrixC[i, j] = matrixC[i,j] + matrixA[r,s] * matrixB[t,v];
               s++;
               t++;
            }
            v++;
        }
        r++;
    }
}

void PrintMatrixC(double[,] matrixC)
{
    Console.WriteLine($"matrix C:");
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            Console.Write($"{matrixC[i, j]} \t");
        }
        Console.WriteLine($"");
    }
}



Console.WriteLine("Enter first matrix rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter first matrix columns number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second matrix columns number");
int k = Convert.ToInt32(Console.ReadLine());


double[,] matrixA = new double[m, n];
double[,] matrixB = new double[n, k];
double[,] matrixC = new double[m, k];

FillMatrixA(matrixA);
FillMatrixB(matrixB);
PrintMatrixA(matrixA);
PrintMatrixB(matrixB);
Multiply(matrixA, matrixB, matrixC);
PrintMatrixC(matrixC);
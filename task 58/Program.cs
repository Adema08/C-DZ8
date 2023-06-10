// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillMatrixWhithRandomNumbers(int[,] matrix1, int[,] matrix2)
{
    Random rand = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rand.Next(-1, 11);
        }
    }
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rand.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationOfMatrix(int[,] matrix1, int[,] matrix2, int m, int y)
{
    int[,] resultMatrix = new int[m, y];
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}

Console.Write("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[x, y];
if (n != x) { Console.WriteLine("Перемножение матриц невозможно"); }
else 
{ 
    FillMatrixWhithRandomNumbers(matrix1, matrix2);
    PrintMatrix(matrix1);
    Console.WriteLine("\n");
    PrintMatrix(matrix2);
    Console.WriteLine("\n");
    PrintMatrix(MultiplicationOfMatrix(matrix1, matrix2, m, y));
}
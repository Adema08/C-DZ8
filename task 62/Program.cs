// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralMatrix(int[,] matrix, int n)
{
    int m = 1;
    for (int i = 0; i < n - 2; i++)
    {
        for (int j = i; j < n - i; j++)
        {
            matrix[i, j] = m;
            m++;
        }
        m--;
        for (int j = i; j < n - i; j++)
        {
            matrix[j, n - 1 - i] = m;
            m++;
        }
        m--;
        for (int j = n - 1 - i; j >= i; j--)
        {
            matrix[n - 1 - i, j] = m;
            m++;
        }
        m--;
        for (int j = n - 1 - i; j >= 1 + i; j--)
        {
            matrix[j, i] = m;
            m++;
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
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
SpiralMatrix(matrix, n);
PrintMatrix(matrix);



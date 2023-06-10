// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrixWhithNumbers(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j, k] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) " + "\t");
            }
            if (i != matrix.GetLength(1) - 1)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}
Console.Write("Введите i: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[m, n, l];
Console.Write($"Введите по очереди {m * n * l} различных двузначных числа \n");
FillMatrixWhithNumbers(matrix);
PrintMatrix(matrix);
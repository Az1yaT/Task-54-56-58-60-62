//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Clear();
int[,] FillMatrixRndInt(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");
            else Console.Write(array[i, j] + "]");
        }
        Console.WriteLine();
    }
}

void SortBacjMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int t = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = t;
                }
            }
        }
    }
}

Console.Write($"Пожалуйста, введите число строк матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Пожалуйста, введите число столбцов матрицы: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Исходный массив: ");
int[,] array = FillMatrixRndInt(row, col);
PrintMatrix(array);

Console.WriteLine($"Сортированный массив: ");
SortBacjMatrix(array);
PrintMatrix(array);


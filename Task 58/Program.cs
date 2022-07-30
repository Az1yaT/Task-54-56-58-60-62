// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] FillFirstMatrix(int m, int n)
{
    int[,] arrayOne = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOne.GetLength(1); j++)
        {
            arrayOne[i, j] = rnd.Next(0, 10);
        }
    }
    return arrayOne;
}

void PrintFirstMatrix(int[,] arrayOne)
{
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOne.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arrayOne.GetLength(1) - 1) Console.Write(arrayOne[i, j] + ",");
            else Console.Write(arrayOne[i, j] + "]");
        }
        Console.WriteLine();
    }
}

int[,] FillSecondMatrix(int m, int n)
{
    int[,] arrayTwo = new int[m, n];
    Random rnd = new Random();
    for (int k = 0; k < arrayTwo.GetLength(0); k++)
    {
        for (int e = 0; e < arrayTwo.GetLength(1); e++)
        {
            arrayTwo[k, e] = rnd.Next(0, 10);
        }
    }
    return arrayTwo;
}

void PrintSecondMatrix(int[,] arrayTwo)
{
    for (int k = 0; k < arrayTwo.GetLength(0); k++)
    {
        for (int e = 0; e < arrayTwo.GetLength(1); e++)
        {
            if (e == 0) Console.Write("[");
            if (e < arrayTwo.GetLength(1) - 1) Console.Write(arrayTwo[k, e] + ",");
            else Console.Write(arrayTwo[k, e] + "]");
        }
        Console.WriteLine();
    }
}

void MultMatrix(int[,] arrayOne, int[,] arrayTwo, int[,] arrayTree)
{
    for (int i = 0; i < arrayTree.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTree.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                sum += arrayOne[i, k] * arrayTwo[k, j];
            }
            arrayTree[i, j] = sum;
        }
    }
}

void PrintThirdMatrix(int[,] arrayThree)
{
    for (int k = 0; k < arrayThree.GetLength(0); k++)
    {
        for (int e = 0; e < arrayThree.GetLength(1); e++)
        {
            if (e == 0) Console.Write("[");
            if (e < arrayThree.GetLength(1) - 1) Console.Write(arrayThree[k, e] + ",");
            else Console.Write(arrayThree[k, e] + "]");
        }
        Console.WriteLine();
    }
}

Console.Write($"Пожалуйста, количество строк первой матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Пожалуйста, количество столбцов первой матрицы: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первая матрица");
int[,] arrayOne = FillFirstMatrix(row, col);
PrintFirstMatrix(arrayOne);
Console.WriteLine("Вторая матрица");
int[,] arrayTwo = FillSecondMatrix(row, col);
PrintSecondMatrix(arrayTwo);
Console.WriteLine("Произведение матриц");
int[,] arrayTree = FillSecondMatrix(row, col);
MultMatrix(arrayOne, arrayTwo, arrayTree);
PrintThirdMatrix(arrayTree);


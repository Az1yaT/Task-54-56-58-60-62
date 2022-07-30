// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (uint i = 0; i < rows; i++)
    {
        for (uint j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixSpirally(int[,] matrix)
{
    int M = matrix.GetLength(0);
    int N = matrix.GetLength(1);
    int count = 0;

    int rows = 0;
    int columns = 0;

    int borderRight = N - 1;
    int borderDown = M - 1;
    int borderLeft = 0;
    int borderUp = 1;

    String direction = "right";

    while (count != N * M)
    {
        matrix[rows, columns] = ++count;

        switch (direction)
        {
            case "right":
                columns++;
                if (columns == borderRight)
                {
                    direction = "down";
                    borderRight--;
                }
                break;

            case "down":
                rows++;
                if (rows == borderDown)
                {
                    direction = "left";
                    borderDown--;
                }
                break;

            case "left":
                columns--;
                if (columns == borderLeft)
                {
                    direction = "up";
                    borderLeft++;
                }
                break;

            case "up":
                rows--;
                if (rows == borderUp)
                {
                    direction = "right";
                    borderUp++;
                }
                break;
        }
    }
}

Console.Write("Введите количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
FillMatrixSpirally(matrix);
PrintMatrix(matrix);
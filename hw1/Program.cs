//Задача 47. Задайте двумерный массив размером m×n,
 //заполненный случайными вещественными числами.
int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m,n];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}

int[,] NewMatrix = CreateMatrix(9, 7, 1, 100);

void PrintMatrix(int[,] matrix1)
{
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix1[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintMatrix(NewMatrix);



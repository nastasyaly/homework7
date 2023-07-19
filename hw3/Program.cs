//Задача 52. Задайте двумерный массив из целых чисел.
 //Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

int[,] NewMatrix = CreateMatrix(5, 7, 1, 10);

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

    for(int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        double rowsSum = 0;
        for(int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            rowsSum = rowsSum  + NewMatrix[i,j];
        }
        Console.WriteLine($"Сумма элементов в строчке {i} = {Math.Round(rowsSum / NewMatrix.GetLength(1),0)}");
    }


for(int i = 0; i < NewMatrix.GetLength(1); i++)
    {
        double columnsSum = 0;
        for(int j = 0; j < NewMatrix.GetLength(0); j++)
        {
            columnsSum = columnsSum  + NewMatrix[j,i];
        }
        Console.WriteLine($"Сумма элементов в столбце {i} = {Math.Round(columnsSum / NewMatrix.GetLength(0),0)}");
    }

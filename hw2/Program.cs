// Задача 50.
int[,] GetMatrix(int rows,int columns,int min,int max)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = new Random().Next(min,max+1);
            }

    }
    return matrix;
}
int rows = new Random().Next(1,10);
int columns = new Random().Next(1,10);
int[,] Matrix1 = GetMatrix(rows, columns, 1, 100);

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

PrintMatrix(Matrix1);

Console.Write("Введите первую позицию элемента от 0 до 100 ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второую позицию элемента от 0 до 100 ");
int b = Convert.ToInt32(Console.ReadLine());
if(a >= rows | b >= columns)
{
     Console.WriteLine($"Числа с позициями [{a} , {b}] в массиве нет ");
}
else
{
     Console.WriteLine($"Вы ввели число из массива");

}
        
    


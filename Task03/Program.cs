// Задача 3: 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void MinRowSum(int[,] matr)
{
    int[] RowSum = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int position = 0;
        //int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            RowSum[i] += matr[i, j];
            position = i;
        }
        Console.WriteLine("В строке № {0} сумма элементов = {1}", position + 1, RowSum[i]);
    }
    int MinSum = 0; // int.MaxValue;
    for (int k = 0; k < RowSum.Length; k++)
    {
        if (RowSum[MinSum] > RowSum[k]) MinSum = k;        
    }
    Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {MinSum + 1}");
}

int[,] matrix = new int[4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinRowSum(matrix);
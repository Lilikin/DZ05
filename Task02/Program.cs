// Задача 2: 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

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

void ReplacingString(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i > 0 && i < matr.GetLength(0))
            {
                int temporary = matr[i, j];
                matr[i, j] = matr[i, j];
                matr[i, j] = temporary;
            }
            else
            {
                int temporary = matr[0, j];
                matr[0, j] = matr[matr.GetLength(0) - 1, j];
                matr[matr.GetLength(0) - 1, j] = temporary;
            }
        }
    }
}


int[,] matrix = new int[5, 4]; 
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ReplacingString(matrix);
PrintArray(matrix);

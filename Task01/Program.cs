// Задача 1: 
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

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

void AcceptsElement(int[,] matr)
{
    Console.WriteLine("Введите номер строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер стобца: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    bool flagFound = false;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == rows - 1 && j == columns - 1)
            {
                flagFound = true;
                break;
            }
        }
    }
    if (flagFound)
    {
        Console.WriteLine($"В массиве есть элемент строки - {rows}, столбца {columns} = {matr[rows-1, columns-1]}");
    }
    else
    {
        Console.WriteLine($"В массиве нет элемента строки - {rows}, столбца {columns}");
    }
    return;    
}

int[,] matrix = new int[4, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
AcceptsElement(matrix);

// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

void Main()
{
    Console.Clear();
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];

    GetArray(array);
    PrintArray(array);
    Console.WriteLine();
    ReplacingStrings(array);
    
    
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i, j] + " "}");
        }
    Console.WriteLine();
    }
}

void ReplacingStrings(int[,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        var tmp = array[3, i];
        array[3, i] = array[0, i];
        array[0, i] = tmp;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Main();

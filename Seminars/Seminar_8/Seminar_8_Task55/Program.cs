// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество стобцов: ");
    int columns = int.Parse(Console.ReadLine());
    int[,] array = new int[rows, columns];

    if (rows > columns || rows < columns)
    {
        Console.WriteLine ("ERROR. Количество строк и столбцов должно быть одинаковым.");
        Console.ReadLine();
    }
    else
    {
    GetArray(array);
    PrintArray(array);
    Console.WriteLine();
    ReplacingColumnsWithRows(array);
    Console.ReadLine();
    } 
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

void ReplacingColumnsWithRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for  (int j = 0; j < array.GetLength(1); j++)
        { 
            array[i, j] = array[i, j];
            Console.Write(array[j, i] + " " );
        }
        Console.WriteLine();
    }
}

Main();
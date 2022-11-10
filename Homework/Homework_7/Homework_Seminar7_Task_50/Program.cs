// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

void Main()
{
    Console.Clear();
    Console.Write("Позиция строки: ");
    int row = int.Parse(Console.ReadLine());
    
    Console.Write("Позиция столбца: ");
    int column = int.Parse(Console.ReadLine());
    int[,] array = new int[3, 4];
    
    GetArr(array);
    PrintArray(array);
    SearchInArray(row, column, array);
}

void GetArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SearchInArray(int m, int n, int[,] arr)
{
    if (m > arr.GetLength(0) || n > arr.GetLength(1))
    {
        Console.WriteLine("Значение элемента отсутсвует.");
    }
    else
    {
        Console.WriteLine($"Значение элемента пересечения позиций строки и столбца: {arr[n - 1, m - 1]}.");
    }
}

Main();
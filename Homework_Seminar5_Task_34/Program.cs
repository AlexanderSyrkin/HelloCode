// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = new int[4];
GetArray(array);
Chetnoe(array);


void GetArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(99, 999); 
    }
Console.Write("[{0}] ", string.Join(", ", array));
}

void Chetnoe(int[] array)
{
    int chetnoe = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        chetnoe++; 
    }
Console.WriteLine($" -> {chetnoe}.");
}

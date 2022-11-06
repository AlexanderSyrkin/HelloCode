// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[10];
int sum = 0;
int n=0;
GetArray(array);
Sum(array);

void GetArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(-100, 100); 
    }
Console.Write("[{0}] ", string.Join(", ", array));
}

void Sum(int[] array)  
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
        n++;
        sum += array[i];
        }
    }
Console.WriteLine($"-> {sum}.");
}

//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] array = new double[7];
GetArray(array);
MinMaxValue(array);

void GetArray(double[] array)
{
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++) 
    {
        array[i] = 100- rand.Next(100) + rand.NextDouble();
    }
Console.Write("[{0}] ", string.Join(", ", array));
}

   
void MinMaxValue(double[] array)
{  
    double dif = 0;
    int imin = 0, imax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[imax])
        {
            imax = i;
        }
        if (array[i] < array[imin])
        {
            imin = i;
        }
    }
    double diff = array[imax] - array [imin];
Console.WriteLine($"-> {Math.Round(diff,2)}");
Console.WriteLine();
Console.WriteLine("min value: array[" + imin + "] = " + Math.Round(array[imin],2));
Console.WriteLine("max value: array[" + imax + "] = " + Math.Round(array[imax],2));
Console.ReadLine();
}



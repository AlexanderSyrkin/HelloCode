// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите № четверти от 1 до 4: ");
int quarter = int.Parse(Console.ReadLine());
if(quarter == 1)
{
    Console.WriteLine("Дипозон точеккоординат в этой четверти: x = 0 +; y = 0 +.");
}
if(quarter == 2)
{
    Console.WriteLine("Дипозон точеккоординат в этой четверти: x = 0 -; y = 0 +.");
}
if(quarter == 3)
{
    Console.WriteLine("Дипозон точеккоординат в этой четверти: x = 0 -; y = 0 -.");
}
if(quarter == 4)
{
    Console.WriteLine("Дипозон точеккоординат в этой четверти: ssx = 0 +; y = 0 +.");
}




// Задача 4: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите цифру № 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите цифру № 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите цифру № 3: ");
int number3 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("Максимальное число: " + number1);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + number3);
    }
}
else
{
    if (number2 > number3)
    {
      Console.WriteLine("Максимальное число: " + number2);  
    }
    else
    {
        Console.WriteLine("Максимальное число: " + number3); 
    }
}
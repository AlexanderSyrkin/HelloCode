//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите цифру № 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите цифру № 2: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine(number2);
}


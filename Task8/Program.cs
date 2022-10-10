// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int index=2;
while (index<=number)
{
    Console.Write(index);
    Console.Write(", ");
    index=index+2;
}



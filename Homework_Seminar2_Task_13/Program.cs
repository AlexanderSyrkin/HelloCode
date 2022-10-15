// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int a1 = number;

if (number < 100)
{
    Console.WriteLine($"{number} -> Третьей цифры нет");
}
else if (a1 > 100000000)
{
    Console.WriteLine("ОШИБКА!!! Слишком большое значение - введите число меньшего размера!");
}
else if (a1 > 10000000)
{
    a1 = number/100000;
    int a3 = (a1%100)%10;
    Console.WriteLine($"{number} -> {a3}");
}
else if (a1 > 1000000)
{
    a1 = number/10000;
    int a3 = (a1%100)%10;
    Console.WriteLine($"{number} -> {a3}");
}
else if (a1 > 100000)
{
    a1 = number/1000;
    int a3 = (a1%100)%10;
    Console.WriteLine($"{number} -> {a3}");
}
else if (a1 > 10000)
{
    a1 = number/100;
    int a3 = (a1%100)%10;
    Console.WriteLine($"{number} -> {a3}");
}
else if (a1 > 1000)
{
    a1 = number/10;
    int a3 = (a1%100)%10;
    Console.WriteLine($"{number} -> {a3}");
}
else if (a1 > 100)
{
    a1 = number/1;
    int a3 = (a1%100)%10;
    Console.WriteLine($"{number} -> {a3}");
}
















	

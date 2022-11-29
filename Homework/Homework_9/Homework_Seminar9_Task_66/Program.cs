// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

void Main()
{
    Console.WriteLine("Введите число N: ");
    int a = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите число M: ");
    int b = int.Parse(Console.ReadLine()!);

    Console.Write("Сумма натуральных чисел между N и M = ");
    Console.WriteLine(SumNumbers(a + 1, b - 1));
}

int SumNumbers(int a, int b)
{
    if (a > b)
    {
        return 0;
    }
    else
    {
        return a + SumNumbers(a + 1, b);
    }
}
Main();
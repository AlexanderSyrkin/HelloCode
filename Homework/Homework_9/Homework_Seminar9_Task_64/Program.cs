// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все чётные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void Main()
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine()!);
    Number(a);
    Console.ReadLine();
}

void Number(int a)
{
    if (a <= 1)
        return;
    else
    {
        if (a % 2 == 0)
        {
            Console.Write($"{a}, ");
            Number(a - 2);
        }
        else
        {
            a--;
            Console.Write($"{a}, ");
            Number(a - 2);
        }
    }
}
Main();
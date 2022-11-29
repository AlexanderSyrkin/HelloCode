// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


void Main()
{
    Console.WriteLine("Введите число N");
    int a= int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите число M ");
    int b = int.Parse(Console.ReadLine()!);

    Console.Write("A(b,a) = ");
    Console.WriteLine(Akkerman(a, b));
}

int Akkerman(int b, int a)
{
    if (b <= 0)
        return a+ 1;
    else
    {
        if (b > 0 && a<= 0)
            return Akkerman(b - 1, 1);
        else if (b > 0 && a> 0)
            return Akkerman(b - 1, Akkerman(b, a- 1));
        return 0;
    }
}
Main();
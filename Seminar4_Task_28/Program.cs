// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(NumberProd(num));

int NumberProd(int number)
{
    int prod = 1;
    while(number > 1)
    {
        prod = prod * number;
        Console.WriteLine($"число {number} = {prod} * {number} = {prod}");
        number--;
        Console.WriteLine(number);
    }
    return prod;
}
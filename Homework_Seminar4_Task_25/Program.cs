// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число № 1 (А): ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число № 2 (B): ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine($"{numberA}, {numberB} -> {Stepen(numberB)}.");

int Stepen(int res)
{
    int result = 1;
        while(numberB > 0)
    {
        result *= numberA;
        numberB--;
    }
    return(result);
}
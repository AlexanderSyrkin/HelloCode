// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} -> {SumNumbers(number)}");

int SumNumbers(int num)
{
    int count = 1; 
    int sum_number = 0;
    int last_digit = 0;
    while(number > 0)
    {
        last_digit = number%10;
        number /= 10;
        sum_number += last_digit;
        count ++;
    }
    return(sum_number);
}

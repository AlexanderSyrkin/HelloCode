// Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5 

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine(NumberDigits(number1));
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine(NumberDigits(number2));
int number3 = int.Parse(Console.ReadLine());
Console.WriteLine(NumberDigits(number3));

int NumberDigits(int number)
{
    int count = 0;
    while(number >= 1)
    {
        number = number/10;
        count++;
    }
    return count;
}

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите 5-ти значное число: ");
int number = int.Parse(Console.ReadLine());
double len = Math.Floor(Math.Log10(number) + 1);

if(len < 5 || len > 5)
{
    Console.WriteLine("Ошибка. Введите 5-ти значное число");
}
else {
    int number1 = number / 10000 % 10;
    int number2 = number / 1000 % 10;
    int number4 = number / 10 % 10;
    int number5 = number % 10;
    if(number1 == number5 && number2 == number4)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else{
        Console.WriteLine($"Число {number} не является палиндромом.");
    }
}
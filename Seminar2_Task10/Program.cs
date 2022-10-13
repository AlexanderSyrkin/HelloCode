// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100,1000);
Console.WriteLine($"{num}");
int a1 = num/100;
int a2 = (num%100)/10;
int a3 = ((num%100)/1)%10;
Console.WriteLine($"{a1}, {a2}, {a3}");
Console.WriteLine($"{num} -> {a1}{a3}");

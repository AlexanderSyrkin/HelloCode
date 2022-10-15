// Напишите программу, которая принимает на вход цифру,
// обозначающаую день недели и проверяет является ли этот
// день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите число от 1-7: ");
int num = int.Parse(Console.ReadLine());
if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5)
{
    Console.WriteLine($"{num} -> рабочий день");
}
if (num == 6 || num == 7)       
{
    Console.WriteLine($"{num} -> выходной день");
}         
if (num > 7 || num < 1)
{
    Console.WriteLine("Ошибка! Введите число от 1-7.");
}
   
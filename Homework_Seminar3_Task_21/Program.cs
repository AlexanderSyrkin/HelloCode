// Задача 21/ 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату № 1 (X) точки A: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("Введите координату № 2 (Y) точки A: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("Введите координату № 3 (Z) точки A: ");
int Az = int.Parse(Console.ReadLine());
Console.Write("Введите координату № 1 (X) точки B: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("Введите координату № 2 (Y)точки B: ");
int By = int.Parse(Console.ReadLine());
Console.Write("Введите координату № 3 (Z) точки B: ");
int Bz = int.Parse(Console.ReadLine());
double result = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)), 2);
Console.WriteLine($"A ({Ax},{Ay},{Az}); B ({Bx}, {By}, {Bz}) -> {result}");
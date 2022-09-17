/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */

Console.WriteLine("Введите три числа");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

if (x > y && x > z)
{
    Console.WriteLine($"max = {x}");
}
else if (y > x && y > z)
{
    Console.WriteLine($"max = {y}");
}
else if (z > x && z > y)
{
    Console.WriteLine($"max = {z}");
}
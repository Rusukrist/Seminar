/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите  второе число: ");
int NumberB = int.Parse(Console.ReadLine());
Console.Write("Введите  третье число: ");
int NumberC = int.Parse(Console.ReadLine());
int maxNumber = 0;
if (NumberA > maxNumber) maxNumber = NumberA;
if (NumberB > maxNumber) maxNumber = NumberB;
if (NumberC > maxNumber) maxNumber = NumberC;
Console.Write("максимальное из трех цифр " + maxNumber);
Console.ReadKey();
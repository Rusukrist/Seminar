/*
 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int remain = Number % 2;
if (remain == 0)
{    Console.WriteLine(" Число " + Number + " является чётным?");
    Console.WriteLine("Да!");
}
else
{    Console.WriteLine(" Число " + Number + " является чётным?");
    Console.WriteLine("Нет!");
}
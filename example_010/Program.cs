/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Вариант решения через индекс элемента строки
string num = Console.ReadLine();
if (num < 100 | num > 999)
{
    System.Console.WriteLine("Введите число от 100 до 999");
}
else
{
    System.Console.WriteLine(num[1]);
}
*/

int num = int.Parse(Console.ReadLine());
if (num < 100 | num > 999)
{
    System.Console.WriteLine("Введите число от 100 до 999");
}
else
{
    System.Console.WriteLine(num % 100 / 10);
}





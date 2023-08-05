/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int num = int.Parse(Console.ReadLine());
if (num > 7 | num < 1)
{
    System.Console.WriteLine("Введите число от 1 до 7");
}
else
{
    if (num > 5) System.Console.WriteLine("Да");
    if (num < 6) System.Console.WriteLine("Нет");
}

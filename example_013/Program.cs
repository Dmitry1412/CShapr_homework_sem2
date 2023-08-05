/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int num = int.Parse(Console.ReadLine());
int count = 10;
if (num < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    while (num > 999)
    {
        num = num / count; 
    }
        System.Console.WriteLine(num % 10);
}

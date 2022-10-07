/* Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
3267912 -> 6 */
Console.Write("Введите число, чтобы узнать третью цифру слева от заданного числа: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
if (num >= 100 && num < 1000)
{
    num = num % 10;
    Console.WriteLine(num);
}
if (num >= 1000 && num < 10000)
{
    num = num / 10;
    int num1 = num % 10;
    Console.WriteLine(num1);
}
if (num >= 10000 && num < 100000)
{
    num = num / 100;
    int num2 = num % 10;
    Console.WriteLine(num2);
}
if (num >= 100000 && num < 1000000)
{
    num = num / 1000;
    int num3 = num % 10;
    Console.WriteLine(num3);
}
if (num >= 1000000 && num < 10000000)
{
    num = num / 10000;
    int num4 = num % 10;
    Console.WriteLine(num4);
}
if (num >= 10000000 && num < 100000000)
{
    num = num / 100000;
    int num5 = num % 10;
    Console.WriteLine(num5);
}
if (num >= 100000000 && num < 1000000000)
{
    num = num / 1000000;
    int num6 = num % 10;
    Console.WriteLine(num6);
}

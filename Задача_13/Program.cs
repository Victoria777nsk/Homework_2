// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = (number % 10);
    Console.WriteLine($"Число = {number}. Третья цифра = {result}");
}
else
{
    Console.WriteLine($"Третьей цифры в числе {number} НЕТ");
}

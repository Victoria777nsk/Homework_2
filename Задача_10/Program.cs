// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа:
// 456 -> 5

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = ((number / 10) % 10);
    Console.WriteLine($"Число = {number}. Вторая цифра = {result}");
}
else
{
    Console.WriteLine($"Ошибка! Число {number} не является ТРЁХзначным :(");
}

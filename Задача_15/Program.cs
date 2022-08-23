// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

switch (dayNumber)
{
    case 1: Console.WriteLine("Нет, день не является выходным"); break;
    case 2: Console.WriteLine("Нет, день не является выходным"); break;
    case 3: Console.WriteLine("Нет, день не является выходным"); break;
    case 4: Console.WriteLine("Нет, день не является выходным"); break;
    case 5: Console.WriteLine("Нет, день не является выходным"); break;
    case 6: Console.WriteLine("Да, день выходной"); break;
    case 7: Console.WriteLine("Да, день выходной"); break;
    default: Console.WriteLine("Ошибка! Цифра должна быть от 1 до 7."); break;
}

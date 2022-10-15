// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int enterNumber, result = 0;
Console.Write("Введите любое число: ");
enterNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"{enterNumber} -> ");

while (enterNumber != 0)
{
    result += enterNumber % 10;
    enterNumber /= 10;
}
Console.WriteLine($"{result}");
            

// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int sum = 1;
for (int i = 1; i <= num; i++)
{
    sum = sum * i;
    // sum += i
}

Console.WriteLine($"сумму чисел от 1 до {num} = {sum}");

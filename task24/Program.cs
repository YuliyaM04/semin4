// Напишите программу, которая  принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= num; i++)
{
    sum = sum + i;
    // sum += i
}

Console.WriteLine($"сумму чисел от 1 до {num} = {sum}");

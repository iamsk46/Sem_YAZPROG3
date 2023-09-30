// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int min = 0; int max = 0;
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > y)
{
    max = x;
    min = y;
}
else
{
    max = y;
    min = x;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);
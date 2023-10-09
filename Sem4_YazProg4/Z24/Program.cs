﻿// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbersToN(int num) // 2. Функция возвращает нам целое число(int), а так же у нее входной параметр - так же целое число(int num)
{
    int sum = 0; // 3. Переменная в которую мы сумируем результат.

    for (int i = 1; i <= num; i++) // Индекс равен 1, потому что первое сложение с 0 можем пропустить; и пока индекс меньше или равен нашему числу мы делаем сложение
    {
        sum += i; //  Сокращение от == sum = sum + 1
    }
    return sum; // ретерн возвращает в нашу функцию значение для нашей переменной
}

System.Console.Write("Введите число: "); // Write - водну строку; WriteLine - спрева напишет то, что у нас в "", а на след.строке то, что после :
int N = Convert.ToInt32(System.Console.ReadLine());
int result = SumNumbersToN(N); // 1. СОЗДАЛИ ПЕРЕМЕННУЮ result, она будет хранить значение из нашей функции
System.Console.WriteLine($"Результат сложения от 1 до {N} = {result}"); // наши переменные в таких скобках
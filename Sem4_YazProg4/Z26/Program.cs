//  Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.



// 1 ВАРИАНТ.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number == 0)
{
Console.WriteLine(1);
} else
{
while (number > 0)
{
count++;
number /= 10;
}

Console.WriteLine(count);
}


//2 Вариант

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine())); // целое число = Маth.abs (берем само число без учета отрицательное оно или положительное) и конвертируем его
string num = Convert.ToString(number); // доп. переменная строкового значения = конвертируем наше число кторое равно строке - наше число 123 стало строкой "123"
System.Console.WriteLine(num.Length); // (num.Length) - обращаемся к строке и выводим количество символов

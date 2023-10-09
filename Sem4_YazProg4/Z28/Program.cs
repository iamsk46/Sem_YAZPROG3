// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int SumNumbersToN(int num) um)
{
    int sum = 1; 

    for (int i = 1; i <= num; i++) 
    {
        sum *= i; 
    }
    return sum;
}

System.Console.Write("Введите число: "); 
int N = Convert.ToInt32(System.Console.ReadLine());
int result = SumNumbersToN(N);
System.Console.WriteLine($"Результат умножения от 1 до {N} = {result}");

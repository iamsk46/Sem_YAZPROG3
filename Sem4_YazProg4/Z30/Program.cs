// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Вариант 1.

// int n=8;       
// int[] mass= new int[n];                             ПЕРВЫМ 'FOR' МЫ СОЗДАЛИ МАССИВ
// for (int i=0; i<n;i++)
//   {
//     mass[i]= new Random().Next(0,2);             2ОЙКА ПОТОМУ ЧТО ПРАВАЯ ЧАСТЬ НЕ ЧИТАЕТСЯ И ПОЛУЧАЕТСЯ ' ОТ 0 ДО 1'
//   }

// for (int i=0; i<n;i++)
//    {                                                ВТОРЫМ МЫ ЕГО ВЫВЕЛИ В КОНСОЛЬ
//      System.Console.Write($"{mass[i]},");
//    }


// Вариант 2.

// int[] mass = new int[8];
// Random rnd = new Random();  -------------- Класс Random, назвали ее rnd и поместили туда(=) все, что связано с нашим Random. После этого мы можем пользоваться rnd всеми методами относящимяся к классу Random.

// for (int i = 0; i < mass.Length; i++)
// {
// mass[i] = rnd.Next(0, 2);
// }

// System.Console.WriteLine('[' + string.Join(", ", mass) + ']'); --------string.Join метод принимает параметр в скобках("знак препинания или пробел между символами", + второй аргумент,в нашем случаем наш массив)

// Вариант 3.

int[] FillArray(int[] arr, Random rnd)
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 2);
}
return arr;
}

int[] mass = new int[8];
Random rnd = new Random();
System.Console.WriteLine('[' + string.Join(", ", FillArray(mass, rnd)) + ']');
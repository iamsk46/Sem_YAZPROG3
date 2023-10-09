// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// System.Console.WriteLine("ВВедите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("ВВедите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if ( x > y && y > 0)
// {
//     System.Console.WriteLine("Наша точка находится в первой четверти");
// }
// else if (x < 0 && y > 0)
// {
//     System.Console.WriteLine("Наша точка находится во второй четверти");
// }
// else if (x < 0 && y < 0)
// {
//     System.Console.WriteLine("Наша точка находится в третьей четверти");
// }
// else
// {
//     System.Console.WriteLine("Наша точка находится в четвертой четверти");
// }

void Nazvanie(int x, int y)
{

if ( x > y && y > 0)
{
    System.Console.WriteLine("Наша точка находится в первой четверти");
}

else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Наша точка находится во второй четверти");
}

else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Наша точка находится в третьей четверти");
}

else
{
    System.Console.WriteLine("Наша точка находится в четвертой четверти");
}

}

System.Console.WriteLine("ВВедите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВедите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

Nazvanie(x, y);
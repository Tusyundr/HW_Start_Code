// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int num_X;

Console.WriteLine("Введите число: ");
num_X = Convert.ToInt32(Console.ReadLine());

if (num_X % 2 == 0)
{
    Console.WriteLine("Число " + num_X + " четное");
}
else
{
   Console.WriteLine("Число " + num_X + " нечетное");  
}

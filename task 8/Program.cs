// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


using System.Runtime.InteropServices;

int N;
Console.WriteLine("Введите число");
N = Convert.ToInt32(Console.ReadLine());
int count=1;
while (count<=N) 
{
    if(count %2 == 0)
    {
       Console.WriteLine($" {N} -> {count}");
       count++; 
    }
    else
         count++;
  
}
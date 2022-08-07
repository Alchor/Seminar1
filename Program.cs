/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int remain = 2;
int even = 2;

while (num >= remain)
while (num >= even)
{
    Console.Write(remain + " ");
    remain = remain + 2;
    Console.Write(even + " ");
    even = even + 2;
}
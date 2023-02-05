/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int b = 1;

while (b <= n)

{

        Console.Write($"{b*b*b} ");
        b++;

}
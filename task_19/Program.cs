/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.Clear();

Console.Write("Введите число: ");

string? number = Console.ReadLine(); // string? number - для того, чтобы показать что ссылочный тип так же может принимать null, ему нужно добавить ? 

void CaseNumber(string number) // void показывает что метод не возвращает ничего.

{
    
    
    if (number[0]==number[4] || number[1]==number[3]) //Обращение к индексу массива
  
    {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - не палиндром.");
}

if (number!.Length == 5) //Обозначаем длину массива

{
  CaseNumber(number);
}
else Console.WriteLine($"Введи правильное число");
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли числом четным(делится ли она на два без остатка).
Console.WriteLine("Введите число:");
int a =int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}

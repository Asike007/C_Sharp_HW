//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);
int a;
a = N%2;
if(a == 1)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}
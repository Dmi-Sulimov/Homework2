/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number;
int secondnumber;

Console.WriteLine("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

secondnumber = (number / 10) % 10;

Console.WriteLine(secondnumber);

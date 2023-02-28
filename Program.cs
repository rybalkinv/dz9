int programm, num;
Boolean begin = true;
 
while (begin)
{
Console.WriteLine("------");
Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
Console.WriteLine("1.адайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
Console.WriteLine("2.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.");
Console.WriteLine("3.Напишите программу вычисления функции Аккермана с помощью рекурсии.  Даны два неотрицательных числа m и n.");

programm = Convert.ToInt32(Console.ReadLine());
 
switch (programm)
{
case 1:
/* Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

*/
 
Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());
 
///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
if (number < 0) Console.Write($"{number} не натуральное число");
if (number == 0) return;
Console.Write("{0,4}", number);
NumberCounter (number - 1);
}
 
NumberCounter(number);
 

 
break;

case 2:
/* Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.*/
 
Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());
 
Console.WriteLine("Введите начальное число M:");
int numberN = int.Parse(Console.ReadLine());
 
///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int numberM, int numberN, int sum)
{
if (numberM > numberN)
{
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
return;
}
sum = sum + (numberM++);
GapNumberSum(numberM, numberN, sum);
}
 
GapNumberSum(numberM, numberN, 0);

break;

case 3:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.  Даны два неотрицательных числа m и n.

 
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
 
int functionAkkerman = Ack(m, n);
 
Console.Write($"Функция Аккермана = {functionAkkerman} ");
 
int Ack(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Ack(m - 1, 1);
else return Ack(m - 1, Ack(m, n - 1));
}
 
int InputNumbers(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
break;



default:
begin = false;
break;
}
}
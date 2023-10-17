// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15. -> 120
// M = 4; N = 8.  -> 30

Console.WriteLine("Введите натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 && numberN < 1)
{
    Console.WriteLine("Ошибка ввода!");
    return;
}


int SumMN(int m, int n)
{
    if(m == n) return m;

    else return SumMN(m + 1, n) + m; 
}
int result = SumMN(numberM, numberN);
Console.WriteLine($" -> {result} ");

// Программа которая на вход принимает 2 целых числа  и проверяет 
// является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"Квадрат числа {number1} равен числу {number2}");
}
else Console.WriteLine("Квадрат числа {0} НЕ равен числу {1}", number1, number2);

// Программа, которая на входе принимает целое число N, а на выходе все целые числа от -N до N

int N = Convert.ToInt32(Console.ReadLine());
int NotN = -N;
while (NotN <= N)
{
    Console.Write($"{NotN} ");
    NotN++;
}

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.

int n = Convert.ToInt32(Console.ReadLine());
int first = n % 10;
int second = n / 10 % 10;
int third = n / 100;
int sum = first + third;
Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine(third);
Console.WriteLine(sum);



Console.WriteLine("Введите трехзначное число: ");
string m = Console.ReadLine()!;

if (m.Length != 3)
{
    Console.Write("Это не трехзначное число...");
}

else
{
    Console.WriteLine(m[0]);
    Console.WriteLine(m[1]);
    Console.WriteLine(m[2]);
}

// Задача 4
Console.WriteLine("Введите первое число");
string number1 = Console.ReadLine() ?? "";
int a = int.Parse(number1);

Console.WriteLine("Введите второе число");
string number2 = Console.ReadLine() ?? "";
int b = int.Parse(number2);

Console.WriteLine("Введите третье число");
string number3 = Console.ReadLine() ?? "";
int c = int.Parse(number3);

int max;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.Write("Максимальное число ");
Console.WriteLine(max);
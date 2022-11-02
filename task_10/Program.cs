// /ДЗ!!! 10 напишите программу которая принимает на вход трехзначное число и на выходе
// показывает вторую цифру этого числа. Через строку решать нельзя
// 456-->5
// 782-->8
// 918-->
Console.WriteLine("Введите трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int a = num;
int digits = 0;

while (a > 0)
{
    digits++;
    a = a / 10;
}
if (digits < 3 || digits > 3)
{
    Console.WriteLine("Введено не трёхзначное число! Введите заново!");
}
else
{
    int numA = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра из числа {num}, цифра: {numA}");
}

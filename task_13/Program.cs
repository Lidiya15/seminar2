// ДЗ 13 Напишите программу ,которая  выводит третью цифру заданного числа или сообщает
//  что третьей цифры нет. Через строку решать нельзя
// 645-->5
// 78--> третьей цифры нет
// // 32679 -->6

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
int a = num;
int digits = 0; // кол-во цифр

while (a > 0)
{
    digits++;
    a = a / 10;
}
if (digits < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int i = 0;
    while (i < digits - 3)
    {
        num = num / 10;
        i++;
    }
    num = num % 10;
    Console.WriteLine($"Третья цифра: {num}");
}

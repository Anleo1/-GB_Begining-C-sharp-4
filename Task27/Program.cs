Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (num < 0) {
    num *= -1;
}
while (num > 0) {
    result += num % 10;
    num /= 10;
}
Console.WriteLine($"Сумма цифр в числе = {result}");
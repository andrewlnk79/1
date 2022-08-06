onsole.Write("введите число a=");

int number = int.Parse(Console.ReadLine());
Console.Write("введите число b=");

int number1 = int.Parse(Console.ReadLine());
Console.Write("введите число c=");
int number2 = int.Parse(Console.ReadLine());
int max;
max = Math.Max(number, Math.Max(number1, number2));
Console.WriteLine(max);

int number=new Random().Next(10,999);
Console.WriteLine("ввели цифру="+number);
if (number / 100 > 0)
{
    Console.WriteLine("вторая цифра числа это:"+(number/10%10));
}

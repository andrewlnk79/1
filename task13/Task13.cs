
using System.Threading.Channels;

int number=new Random().Next(1,2000);
Console.WriteLine("ввели цифру="+number);
if (number / 100 > 0)
{
    Console.WriteLine("третья цифра числа это:"+(number/100%10));
}
Console.WriteLine("у числа нет 3ей цифры");
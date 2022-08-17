Console.WriteLine("введите число:");
int num = int.Parse(Console.ReadLine());
if (num > 0)
{
    for (int i = 1; i <= num; i++)

        System.Console.WriteLine(Math.Pow(i, 3) + " ");
}



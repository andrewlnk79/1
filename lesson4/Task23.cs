using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson4
{
    public class Task23
    {

        System.Console.Write("введите число:");
            int num = int.Parse(Console.ReadLine());
        int result = Math.Pow(num, 3);
        System.Console.WriteLine("число" + num  + "в кубе =" + result);

        
    }
}
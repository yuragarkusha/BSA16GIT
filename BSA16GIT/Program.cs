using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSA16GIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  1 число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите  2 число:");
            int b = Convert.ToInt32(Console.ReadLine());
            int plusValue = Calculator.Plus(a,b);
            int minusValue = Calculator.Minus(a, b);
            Console.WriteLine("Сумма чисел: "+ plusValue);
            Console.WriteLine("Разница чисел: " + minusValue);
            Console.ReadLine();
        }
    }
}

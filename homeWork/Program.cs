using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            second();
        }
      static void first()
        {
            Console.WriteLine("Введите ФИО");
            string str =Console.ReadLine();
            Console.WriteLine("Приветствую тебя,"+str);
        }
        static void second()
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(sum);
        }
    }
}

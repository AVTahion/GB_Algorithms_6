using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  1.  Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе получается сумма кодов символов.
    2.  Переписать программу, реализующее двоичное дерево поиска:
            а)  Добавить в него обход дерева различными способами.
            б)  Реализовать поиск в нём.
            в)  *Добавить в программу обработку командной строки с помощью которой можно указывать, из какого файла считывать данные, каким образом обходить дерево.
    
    Александр Кушмилов
*/

namespace GB_Algorithms_6
{
    class Program
    {
        static double SimpleHash(string input)
        {
            double res = 0;
            foreach (char item in input)
            {
                res += Math.Log(item);
            }
            return res;
        }
        static void Main(string[] args)
        {
            string a = "gjkgfydtbs";
            Console.WriteLine(SimpleHash(a));
            Console.WriteLine(SimpleHash("g"));
            Console.ReadKey();
        }
    }
}

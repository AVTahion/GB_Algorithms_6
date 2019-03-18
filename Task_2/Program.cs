using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2.  Переписать программу, реализующее двоичное дерево поиска:
            а)  Добавить в него обход дерева различными способами.
            б)  Реализовать поиск в нём.
            в)  *Добавить в программу обработку командной строки с помощью которой можно указывать, из какого файла считывать данные, каким образом обходить дерево.
    
    Александр Кушмилов
*/



namespace Task_2
{
    class Program
    {
        static void PrintTree(int i, ref int[] tree)
        {
            if (i < tree.Length && tree[i] != 0)
            {
                Console.Write(tree[i]);
                if ((i * 2 < tree.Length && tree[i * 2] != 0) || (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0))
                {
                    Console.Write('(');
                    if (i * 2 < tree.Length && tree[i * 2] != 0)
                    {
                        PrintTree(i * 2, ref tree);
                    }
                    else
                    {
                        Console.Write("NULL");
                    }
                    Console.Write(',');
                    if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                    {
                        PrintTree(i * 2 + 1, ref tree);
                    }
                    else
                    {
                        Console.Write("NULL");
                    }
                    Console.Write(')');

                }
            }
        }

        /// <summary>
        /// Метод обхода дерева ЛПК
        /// </summary>
        /// <param name="i"></param>
        /// <param name="tree"></param>
        static void LRRoot(int i, ref int[] tree)
        {
            if (i == 1) Console.WriteLine("LRRoot");
            if (i < tree.Length && tree[i] != 0)
            {
                if (i * 2 < tree.Length && tree[i * 2] != 0)
                {
                    LRRoot(i * 2, ref tree);
                }
                if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                {
                    LRRoot(i * 2 + 1, ref tree);
                }
                Console.Write(tree[i]+" ");
            }
        }

        /// <summary>
        /// Метод обхода дерева ЛКП
        /// </summary>
        /// <param name="i"></param>
        /// <param name="tree"></param>
        static void LRootR(int i, ref int[] tree)
        {
            if (i == 1) Console.WriteLine("LRootR");
            if (i < tree.Length && tree[i] != 0)
            {
                if (i * 2 < tree.Length && tree[i * 2] != 0)
                {
                    LRootR(i * 2, ref tree);
                }
                Console.Write(tree[i] + " ");
                if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                {
                    LRootR(i * 2 + 1, ref tree);
                }
            }
        }

        /// <summary>
        /// Метод обхода дерева КЛП
        /// </summary>
        /// <param name="i"></param>
        /// <param name="tree"></param>
        static void RootLR(int i, ref int[] tree)
        {
            if (i == 1) Console.WriteLine("RootLR");
            if (i < tree.Length && tree[i] != 0)
            {
                Console.Write(tree[i] + " ");
                if (i * 2 < tree.Length && tree[i * 2] != 0)
                {
                    LRootR(i * 2, ref tree);
                }
                if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                {
                    LRootR(i * 2 + 1, ref tree);
                }
            }
        }

        /// <summary>
        /// Метод обхода дерева КПЛ
        /// </summary>
        /// <param name="i"></param>
        /// <param name="tree"></param>
        static void RootRL(int i, ref int[] tree)
        {
            if (i == 1) Console.WriteLine("RootRL");
            if (i < tree.Length && tree[i] != 0)
            {
                Console.Write(tree[i] + " ");
                if (i * 2 + 1 < tree.Length && tree[i * 2 + 1] != 0)
                {
                    RootRL(i * 2 + 1, ref tree);
                }
                if (i * 2 < tree.Length && tree[i * 2] != 0)
                {
                    RootRL(i * 2, ref tree);
                }
            }
        }

        /// <summary>
        /// Медот поиска значения в бинарном дереве поиска, реализованного массивом
        /// </summary>
        /// <param name="n">Искомое значение</param>
        /// <param name="tree">Бинарное дерево поиска</param>
        /// <returns>Индекс элемента массива или -1 в случае отсутствия искомого в дереве</returns>
        static int FindN(int n, int[] tree)
        {
            int i = 1;
            while (i < tree.Length)
            {
                if (n == tree[i]) return i;
                if (n < tree[i]) i *= 2;
                else i = 2 * i + 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] tree = { 0, 8, 3, 10, 1, 6, 0, 14, 0, 0, 4, 7, 0, 0, 13, 0 };
            PrintTree(1, ref tree);
            Console.WriteLine();
            LRRoot(1, ref tree);
            Console.WriteLine();
            LRootR(1, ref tree);
            Console.WriteLine();
            RootLR(1, ref tree);
            Console.WriteLine();
            RootRL(1, ref tree);
            Console.WriteLine();
            Console.WriteLine(FindN(14, tree));
            Console.WriteLine(FindN(6, tree));
            Console.WriteLine(FindN(20, tree));

            Console.ReadKey();
        }
    }
}

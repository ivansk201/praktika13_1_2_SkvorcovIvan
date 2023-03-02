using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace praktika13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                ArrayList list = new ArrayList();
                ArrayList list2 = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "Петров" });
                Console.Write("Введите сколько строк вы будете записывать в коллекцию: ");
                int count = Convert.ToInt32(Console.ReadLine());
                if (count < 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число строк");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                Console.Write("Введите индекс, после которого будет вставлена коллекция: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                if (n1 < 0)
                {
                    Console.WriteLine("Вы ввели отрицательный индекс");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                Console.Write("Введите кол-во K элементов, которые будут удалены: ");
                int K = Convert.ToInt32(Console.ReadLine());
                if (K < 0)
                {
                    Console.WriteLine("Вы ввели отрицательное число элементов для удаления");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Введите {i + 1} строку");
                    list2.Add(Console.ReadLine());
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Старый список: ");
                foreach (object c in list)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Новый список: ");
                list.InsertRange(n1, list2);
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                Console.WriteLine("-----------------------------------------");
                Console.Write("После какого элемента будет призводится удаление: ");
                int del = Convert.ToInt32(Console.ReadLine());
                if (list.Count - del - K >= 0)
                {
                    list.RemoveRange(del, K);
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Изменненый список:");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                else Console.WriteLine("Невозможно удалить так много элементов, в коллекцию нет столько элементов");
                Console.WriteLine("-----------------------------------------");
               
            }
            catch { Console.WriteLine("Ошибка ввода данных, Повторите попытку."); }
            Console.ReadKey();
        }
    }
}

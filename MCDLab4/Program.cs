using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCDLab4_Lib;
using System.Diagnostics;

namespace MCDLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomm ran=new Randomm();
            linpoisk linposk = new linpoisk();
            binpos binposk = new binpos();
            int kol, ch1, temp1 = 0, a, b, ob;
            int[] otv = new int[3];
            while(true)
            {
                while (true)
                {
                    Console.Write("Введите длинну массива: ");
                    kol = Convert.ToInt32(Console.ReadLine());
                    if (kol > 0)
                        break;
                    else
                        Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                }
                int[] array = new int[kol];
                while (true)
                {
                    Console.WriteLine("Выберите метод заполнения массива:\n1. С клавиатуры\n2. Рандомные числа с определенного диапазона ");
                    ch1 = Convert.ToInt32(Console.ReadLine());
                    if (ch1 == 1 || ch1 == 2)
                        break;
                    else
                        Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                }
                if(ch1==1)
                {
                    for (int i=0;i<kol;i++)
                    {
                        array[i]= Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                {
                    while (true)
                    {


                        Console.WriteLine("Введите пределы диапазона генерируемых чисел(прим. 10 5000:");
                        Console.Write("Введите нижний предел(а): ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите верхний предел(b): ");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (a < b)
                            break;
                        else
                            Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                    }
                    array = ran.gen_ran(array, kol, a, b);
                    
                }
                
                Console.WriteLine("Заполненный массив:");
                for(int i=0;i<kol;i++)
                {
                    Console.Write("{0} ", array[i]);
                    temp1 = 0;
                    temp1++;
                    if(temp1==30)
                    {
                        temp1 = 0;
                        Console.Write("\n");
                    }
                }
                Console.Write("\nВведите образец элемента поиска: ");
                ob= Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    Console.Write("Выберите алгоритм поиска:\n1. Линейный поиск(без барьера)\n2. Бинарный поиск\n3. IndexOf()\n");
                    temp1= Convert.ToInt32(Console.ReadLine());
                    if (temp1 == 1 || temp1 == 2 || temp1 == 3)
                        break;
                    else
                        Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                }
                switch(temp1)
                {
                    case 1:
                        {
                            
                                otv = linposk.poisk(kol, array, ob);
                            if (otv[0] == -1)
                                Console.WriteLine("Элемент не найден.\n Количество операций сравнений(всех операций): {0}", otv[1]);
                            else
                                Console.WriteLine("Элемент {0} найден. Индекс искомого элемента {1}.Количество операций сравнений(всех операций): {2}.", ob, otv[1]-1, otv[1]);
                            break;
                        }
                    case 2:
                        {
                            temp1 = 0;
                            Array.Sort(array);
                            Console.WriteLine("Отсортированный массив:");
                            for (int i = 0; i < kol; i++)
                            {
                                Console.Write("{0} ", array[i]);
                                temp1++;
                                if (temp1 == 30)
                                {
                                    temp1 = 0;
                                    Console.Write("\n");
                                }
                            }
                            otv = binposk.poisk(array, kol, ob);
                            if (otv[2] == -1)
                                Console.WriteLine("Элемент не найден.\nКоличество сравнений: {0}\nКоличество присваиваний: {1}\nСумма операций: {2}", otv[1], otv[0], otv[0]+otv[1]);
                            else
                                Console.WriteLine("Элемент {0} найден.\nКоличество сравнений: {1}\nКоличество присваиваний: {2}\nСумма операций: {3}", ob, otv[1], otv[0], otv[0] + otv[1]);
                            break;
                        }
                    case 3:
                        {
                            temp1 = Array.IndexOf(array, ob);
                            if(temp1!=-1)
                            Console.WriteLine("Индекс числа {0} первого вхождения: {1}", ob, temp1);
                            else
                                Console.WriteLine("Число {0} не существует в данном массиве", ob);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                            break;
                        }
                }
            }
        }
    }
}

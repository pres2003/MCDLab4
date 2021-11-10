using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MCDLab4_Lib
{
    //заполнение массива рандомными числами
    public class Randomm
    {
        public int[] gen_ran(int[] array, int kol, int a, int b)
        {
            Random ken = new Random();
            for(int i=0;i<kol;i++)
            {
                array[i] = ken.Next(a, b+1);
            }
            return array;
        }
    }
    //Бинарный поиск
    public class binpos
    {

        public int[] poisk(int[] array, int kol, int ob)
        {
            int[] otv = new int[3];
            int l, n, i = 0, pr = 0, sr = 0;
            l = 0;
            pr++;
            n = kol - 1;
            pr++;
            while (true)
            {
                sr++;
                if (l <= n)
                {
                    i = (l + n) / 2;
                    pr++;
                }
                else
                {
                    i = -1;
                    otv[0] = pr;
                    otv[1] = sr;
                    otv[2] = i;
                    return otv;
                }
                sr++;
                if (ob != array[i])
                {
                    if (ob > array[i])
                    {
                        l = i + 1;
                        pr++;
                    }
                    else
                    {
                        n = i - 1;
                        pr++;
                    }
                }
                else
                {
                    otv[0] = pr;
                    otv[1] = sr;
                    otv[2] = pr + sr;
                    return otv;
                }
            }
        }
    }
}

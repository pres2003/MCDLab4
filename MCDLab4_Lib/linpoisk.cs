using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace MCDLab4_Lib
{
    //линейный поиск
    public class linpoisk
    {

        public int[] poisk(int kol, int[] array, int ob)
        {
            int[] otv = new int[2];
            int check = 0;
            int sr = 0;
            for (int i = 0; i < kol; i++)
            {
                sr++;
                if (array[i] == ob)
                {
                    check = 0;
                    break;
                }
                else
                    check = -1;
            }
            otv[0] = check;
            otv[1] = sr;
            return otv;
        }
    }
}

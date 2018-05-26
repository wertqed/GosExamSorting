using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GosExamSorting
{
    class CountingSort
    {
        /**
         * Cортировка подсчетом 
         * Последовательно пройдём по массиву A и запишем в C[i] количество чисел, равных i.
         * Теперь достаточно пройти по массиву C и для каждого number∈{0,...,k−1} в массив A последовательно записать число C[number] раз.
         * */
        public static int[] Sort(int [] array)
        {
            int max = 1000; //Максимальное значение
            int[] c = new int[max];
            for(int i = 0; i< c.Length; i++)
            {
                c[i] = 0;
            }
            for(int i =0; i< array.Length; i++)//закидываем в темповый массив числа из исходного массива, если a[i]=9, то c[9]=1
            {                                   //Если несколько 9 в исходном массиве то c[9] будет равно количеству 9
                c[array[i]] = c[array[i]] + 1;
            }
            int pos = 0;
            for(int i = 0; i < max; i++)//Cобираем полученный темповый массив в исходный
            {
                for (int j = 0; j < c[i]; j++)//Соответсвеноо c[i] равно числу повторений числа в исходном массиве
                {
                    array[pos] = i;
                    pos++;
                }
            }
            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GosExamSorting
{
    class GnomeSort
    {
        /**
         * Гномья сортировка
         * Алгоритм находит место, где два соседних элемента стоят в неправильном порядке и меняет их местами. 
         * */
        public static int[] Sort(int[] array)
        {
            int i = 1;
            while (i < array.Length)
            {
                if (i == 0 || array[i - 1] <= array[i]) i++; //переходим к следующему элементу
                else
                {
                    int temp = array[i];//меняем элементы местами и спукаемся по массиву к исходному элементу
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                    --i;
                }
            }
            return array;
        }
    }
}

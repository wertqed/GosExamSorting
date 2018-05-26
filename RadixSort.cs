using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GosExamSorting
{
    public static class RadixSort
    {
        /**
         * Поразрядная сортировка
         * 1. Создаем пустые списки, количество которых равно числу range.
         * 2. Распределяем исходные числа по этим спискам в зависимости от величины младшего разряда (по возрастанию).
         * 3. Собираем числа в той последовательности, в которой они находятся после распределения по спискам.
         * 4. Повторяем пункты 2 и 3 для всех более старших разрядов поочередно.
         * */
        public static int[] Sort(int[] arr)
        {
            int range = 10; //Количество массивов для разбиения(грубо говоря это система счисления)
            int length = 3; //максимальая длинна
            ArrayList[] lists = new ArrayList[range];
            for (int i = 0; i < range; ++i)
                lists[i] = new ArrayList();

            for (int step = 0; step < length; ++step)
            {
                //распределение по спискам
                for (int i = 0; i < arr.Length; ++i)
                {
                    int temp = (arr[i] % (int)Math.Pow(range, step + 1)) /
                                                  (int)Math.Pow(range, step);//вычисляем значение текущего разряда и кладем в соотв лист
                    lists[temp].Add(arr[i]);                                 //для первого прогона у 98 - элемент пололожиться в 8 лист
                                                                             // для второй итерации соответственно в 9 лист
                }
                //собираем все списки в один массив
                int k = 0;
                for (int i = 0; i < range; i++)
                {
                    for (int j = 0; j < lists[i].Count; j++)
                    {
                        arr[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; i++) //Чистим значения списков для следующего разбиения
                    lists[i].Clear();
            }
            return arr;
        }
    }
}

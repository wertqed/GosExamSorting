﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GosExamSorting
{
    public static class QuickSort
    {
        /**
         * Быстрая сортировка
         * 
         * 1.Из массива выбирается элемент a[i].
         *          Как правило, в качестве этого элемента берется центральный элемент массива.
         * 2.Остальные элементы распределяются таким образом, 
         *      чтобы слева от a[i] оказались все элементы, меньшие или равные a[i]. 
         *      Элементы, большие или равные a[i], помещаются справа.
         * 3.Производится проверка количества элементов в левой и правой частях массива. 
         *      Если какая-либо часть (или обе части) содержит более двух элементов, 
         *      то для этой части (или частей) запускается та же процедура сортировки с помощью рекурсивного вызова.
         */
        public static int[] Sort(int[] array)
        {
            if (array.Length < 2) { return array; }//проверяем количество элементов
            int p = array[array.Length/2];//Берем центральный элемент
            return Sort(array.Where(x => x < p).ToArray()) //Элементы меньше центрального сортируем
                .Concat(array.Where(x => x == p))//равные центральному кладем после прошлых значений
                .Concat(Sort(array.Where(x => x > p).ToArray()))//сортируем значения больше центрального
                .ToArray();
        }
    }
}

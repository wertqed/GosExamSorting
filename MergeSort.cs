using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GosExamSorting
{
    public static class MergeSort
    {
        /**
         * Сортировка слиянием 
         * 
         * Суть метода в том чтобы разбить на кучу мелких массивов и в обратном порядке их сортировать
         * */
        public static int[] Sort(int[] array)
        {
            //проверка длинны массива
            //если длина равна 1, то возвращаем массив, 
            //так как он не нуждается в сортировке
            if (array.Length > 1)
            {
                //массивы для хранения половинок входящего буфера
                int[] left = new int[array.Length / 2];
                //для проверки ошибки некорректного разбиения массива,
                //в случае если длина непарное число
                int[] right = new int[array.Length - left.Length];

                //заполнение субмассивов данными из входящего массива
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = array[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = array[left.Length + i];
                }
                //если длина субмассивов больше еденици,
                //то мы повторно (рекурсивно) вызываем функцию разбиения массива
                if (left.Length > 1)
                    left = Sort(left);
                if (right.Length > 1)
                    right = Sort(right);
                //сортировка слиянием половинок
                array = SubArrSorts(left, right);
            }
            //возврат отсортированного массива
            return array;
        }

        static int[] SubArrSorts(int[] left, int[] right)
        {
            //буфер для отсортированного массива
            int[] buff = new int[left.Length + right.Length];
            //счетчики длины трех массивов
            int i = 0;  //соединенный массив
            int l = 0;  //левый массив
            int r = 0;  //правый массив
                        //сортировка сравнением элементов
            for (; i < buff.Length; i++)
            {
                //если правая часть уже использована, дальнейшее движение происходит только в левой
                //проверка на выход правого массива за пределы
                if (r >= right.Length)
                {
                    buff[i] = left[l];
                    l++;
                }
                //проверка на выход за пределы левого массива
                //и сравнение текущих значений обоих массивов
                else if (l < left.Length && left[l] < right[r])
                {
                    buff[i] = left[l];
                    l++;
                }
                //если текущее значение правой части больше
                else
                {
                    buff[i] = right[r];
                    r++;
                }
            }
            //возврат отсортированного массива
            return buff;

        }
    }
}

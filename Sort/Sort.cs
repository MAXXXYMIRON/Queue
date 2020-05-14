namespace Sort
{
    static class Sort
    {
        /// <summary>
        /// Поразрядная сортировка массива двухразрядных десятичных натуральных чисел. 
        /// </summary>
        public static void Distribute(int[] a, int lenQueue = 50)
        {
            //Создание массива из 10 очередей
            Queue<int>[] digit = new Queue<int>[10];
            int index = 0;

            for (int i = 0; i < 10; i++)
            {
                //Выделение памяти под очереди
                //если второй параметр не передан в функцию
                //выделяется 50 элементов
                digit[i] = new Queue<int>(lenQueue);
            }

            //Распределение по бункерам в соответсвии с еденицами
            for (int i = 0; i < a.Length; i++)
            {
                digit[a[i] % 10].Enqueue(a[i]);
            }

            //Вставка эл. бункеров в массив
            for (int i = 0; i < 10; i++)
            {
                while (!digit[i].IsEmpty)
                {
                    a[index++] = digit[i].Dequeue();
                }
            }

            //Распределение по бункерам в соответсвии с десятками
            for (int i = 0; i < a.Length; i++)
            {
                digit[a[i] / 10].Enqueue(a[i]);
            }

            //Вставка эл. бункеров в массив
            index = 0;
            for (int i = 0; i < 10; i++)
            {
                while (!digit[i].IsEmpty)
                {
                    a[index++] = digit[i].Dequeue();
                }
            }
        }
    }
}

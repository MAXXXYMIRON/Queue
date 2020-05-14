using System;
using System.Collections.Generic;

namespace Sort
{
    class Stack<T>
    {
        List<T> stack = new List<T>();

        /// <summary>
        /// Величина стека. 
        /// </summary>
        public readonly int Length;
        /// <summary>
        /// Конструктор, поумолчанию задает 50 эл. в стеке. 
        /// </summary>
        public Stack()
        {
            Length = 50;
        }
        /// <summary>
        /// Конструтор с заданием величины стека.
        /// </summary>
        public Stack(int count)
        {
            Length = count;
        }

        /// <summary>
        /// Получить верхний элемент не удаляя его из стека. 
        /// </summary>
        public T Peek()
        {
            if (stack.Count == 0) throw new Exception("Стек пуст!");
            return stack[stack.Count - 1];
        }
        
        /// <summary>
        /// Получить элемент из стека удалив его. 
        /// </summary>
        public T Pop()
        {
            if (stack.Count == 0) throw new Exception("Стек пуст!");
            T item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return item;
        }

        /// <summary>
        /// Поместить элемент в стек. 
        /// </summary>
        public void Push(T item)
        {
            if (stack.Count == Length) throw new Exception("Стек полон!");
            stack.Add(item);
        }
        
        /// <summary>
        /// Проверить элемент на наличие в стеке. 
        /// </summary>
        public bool Contains(T item) => stack.Contains(item);

        /// <summary>
        /// Очистить стек. 
        /// </summary>
        public void Clear() => stack.Clear();

        /// <summary>
        /// Кол-во элементов в стеке. 
        /// </summary>
        public int Count => stack.Count;

        /// <summary>
        /// Проверить пуст ли стек. 
        /// </summary>
        public bool IsEmpty => (stack.Count == 0);

        /// <summary>
        /// Проверить полон ли стек. 
        /// </summary>
        public bool IsFull => (stack.Count == Length);
    }
}

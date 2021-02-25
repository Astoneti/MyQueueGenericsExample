using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyQueueGenericsExample
{
    class Queue <T>
    {
        private int size;        // текущий размер стека
        private List<T> data;
        public int Count { get { return data.Count; } }
        public Queue ()
        {
            data = new List<T>();
            size++;
        }

        private T GetItem()
        {
          //  Получаем первый элемент.
           T item = data.FirstOrDefault();

           // Если элемент пуст, то сообщаем об ошибке.
            if (item == null)
            {
                throw new Exception("Queue is empty,no elements for use.");
            }
            return item;
        }

        public void Enqueue(T item)   //Добавить элемент в очередь.
        {
            data.Add(item);
            size++;
        }

        //Получить элемент из очереди с удалением.
        public T Dequeue ()
        {
            // Получить элемент из начала очереди.
            T item = data.FirstOrDefault();
            // Удаляем элемент из коллекции.
            data.Remove(item);
            size--;
            // Возвращаем полученный элемент.
            return item;
        }

        // чтение главного элемента очереди без удаления
        public T Peek()
        {
            // Получаем элемент из начала очереди.
            T item = GetItem();
            // Возвращаем полученный элемент.
            return item;
        }

        // Очищаем список
        public void Clear()
        {
            data.Clear();
        }
    }
}

using System;

namespace MyQueueGenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новую очередь.
            Queue<string> myQueue = new Queue<string>();

            // Добавляем новые элементы в очередь.
            myQueue.Enqueue("One");
            myQueue.Enqueue("Two");
            myQueue.Enqueue("Three");
            Console.WriteLine($"\nThe queue contains : {myQueue.Count} elements.");

            // Получаем элементы с удалением.
            string item1 = myQueue.Dequeue();
            Console.WriteLine($"\nFirst element from queue : {item1}.");
            string item2 = myQueue.Dequeue();
            Console.WriteLine($"\nSecond element from queue : {item2}.");

            // Добавляем новый элемент в очередь.
            myQueue.Enqueue("\nNew element - Ten");
          
            // Просматриваем элемент без удаления.
            string item3 = myQueue.Peek();
            Console.WriteLine($"\nView the element without remove : {item3}.");
            myQueue.Clear();
            Console.ReadLine();
        }
    }
}

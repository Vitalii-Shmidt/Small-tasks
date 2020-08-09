/*
Создать список из заданного к-ва элементов. Выполнить циклический сдвиг этого списка на N элементов вправо или влево.
*/
using System;

namespace Kek
{ 
    public class Task522
    {
        private int[] _items;
        public Task522(int n)
        {
            _items = new int[n];
            for (var i = 0; i < n; ++i)
            {
                _items[i] = i;
            }
        }

        public Task522() : this(0)
        {
        }

        // Есть массив 1 2 3 4 5
        // Циклический сдвиг вправо на 2 элемента: 4 5 1 2 3
        public void MoveRight(int n)
        {
            var length = _items.Length;
            var newItems = new int[length];
            
            var shift = n % length;

            for (int i = shift, j = 0; i < length; ++i, ++j)
            {
                newItems[i] = _items[j];
            }

            for (int i = length - shift, j = 0; j < shift; ++i, ++j)
            {
                newItems[j] = _items[i];
            }
            
            _items = newItems;
        }

        public void MoveLeft(int n)
        {
            var length = _items.Length;
            var shift = n % length;
            var newItems = new int[length];

            for (int i = shift, j = 0; i < length; ++i, ++j)
            {
                newItems[j] = _items[i];
            }

            for (int i = 0, j = length - shift; i < shift; ++i, ++j)
            {
                newItems[j] = _items[i];
            }
            
            _items = newItems;
        }
        public void Print()
        {
            foreach (var item in _items)
            {
                Console.Write(item + " ");
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var kek = new Task522(10);
            Console.WriteLine("Before: ");
            kek.Print();
            kek.MoveLeft(1);
            Console.WriteLine("\nAfter: ");
            kek.Print();
        }   
    }
}
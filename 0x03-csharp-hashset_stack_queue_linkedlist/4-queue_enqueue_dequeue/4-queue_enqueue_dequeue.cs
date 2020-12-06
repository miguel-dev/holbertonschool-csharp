using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int number = aQueue.Count;
        bool contains = aQueue.Contains(search);
        Console.WriteLine($"Number of items: {number}", number.ToString());

        if (number == 0)
        {
            Console.WriteLine("Queue is empty");
            aQueue.Enqueue(newItem);
            Console.WriteLine($"Queue contains \"{search}\": {contains}", search, contains.ToString());
            return aQueue;
        }

        string first = aQueue.Peek();
        Console.WriteLine($"First item: {first}", first);

        aQueue.Enqueue(newItem);

        Console.WriteLine($"Queue contains \"{search}\": {contains}", search, contains.ToString());

        Queue<string> copy = new Queue<string>(aQueue);
        if (contains)
        {
            string deleted = String.Empty;
            foreach (string item in copy)
            {
                deleted = aQueue.Dequeue();
                if (deleted == search)
                {
                    break;
                }
            }
        }
        return aQueue;
    }
}
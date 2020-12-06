using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int number = aStack.Count;
        string top = aStack.Peek();
        bool contains = aStack.Contains(search);
        Console.WriteLine($"Number of items: {number}", number.ToString());
        Console.WriteLine($"Top item: {top}", top);
        Console.WriteLine($"Stack contains \"{search}\": {contains}", search, contains.ToString());

        Stack<string> copy = new Stack<string>(aStack);
        if (contains)
        {
            string deleted = String.Empty;
            foreach (string item in copy)
            {
                deleted = aStack.Pop();
                
                if (deleted == search)
                {
                    break;
                }
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
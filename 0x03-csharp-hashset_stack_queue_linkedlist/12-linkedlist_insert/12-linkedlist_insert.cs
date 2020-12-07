using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0)
        {
            return myLList.AddFirst(n);
        }
        
        LinkedListNode<int> node = myLList.First;
        if (n < node.Value)
        {
            return myLList.AddFirst(n);
        }

        if (myLList.Count == 1 && n > node.Value)
        {
            return myLList.AddAfter(node, n);
        }
        node = node.Next;
        while (node != myLList.Last)
        {
            if (n > node.Previous.Value && n < node.Value)
            {
                return myLList.AddBefore(node, n);
            }
            node = node.Next;
        }
        return myLList.AddAfter(node, n);
    }
}

using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First.Next;
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

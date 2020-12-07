using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        LinkedListNode<int> node = myLList.First;
        myLList.Remove(node);
        return node.Value;
    }
}
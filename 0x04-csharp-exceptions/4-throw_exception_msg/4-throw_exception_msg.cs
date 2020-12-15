using System;

class Except : Exception
{
    public static void ThrowMsg(string msg)
    {
        throw new Exception(msg);
    }
}
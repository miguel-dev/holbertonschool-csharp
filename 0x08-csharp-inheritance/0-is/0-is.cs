using System;
/// <summary>Contains method to check if object is int.</summary>
class Obj
{
    /// <summary>Returns True if object is int, False otherwise.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
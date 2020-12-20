using System;

/// <summary>
/// Contains a method to check if an object is an instance of Array or an instance of
/// a subclass of it.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if the object is an instance of, or if it's an instance of a class 
    /// that inherits from Array.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj) || obj.GetType().IsSubclassOf(typeof(Array)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
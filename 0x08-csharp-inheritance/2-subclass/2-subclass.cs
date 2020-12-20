using System;

/// <summary>Contains method to determine if a type derives from another.</summary>
class Obj
{
    /// <summary>Checks if a Type inherits of another.</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
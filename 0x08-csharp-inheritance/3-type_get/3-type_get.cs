using System;
using System.Reflection;
using System.Collections.Generic;

/// <summary>Contains a method that prints available properties and
/// methods of an object.
/// </summary>
class Obj
{
    /// <summary>Prints properties and methods of an object.</summary>
    public static void Print(object myObj)
    {
        TypeInfo t_info = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> properties = myObj.GetType().GetProperties();
        IEnumerable<MethodInfo> methods = myObj.GetType().GetMethods();

        Console.WriteLine("{0} Properties:", t_info.Name);
        
        foreach (PropertyInfo p in properties)
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine("{0} Methods:", t_info.Name);

        foreach (MethodInfo m in methods)
        {
            Console.WriteLine(m.Name);
        }
    }
}
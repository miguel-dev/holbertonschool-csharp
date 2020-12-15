using System;

class Int
{
    public static void divide(int a, int b)
    {
        int q = 0;
        try {
            q = a/b;
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Cannot divide by zero");
        }
        finally {
            Console.WriteLine($"{a} / {b} = {q}", a, b, q);
        }
    }
}
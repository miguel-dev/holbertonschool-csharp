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
            b = 0;
        }
        finally {
            Console.WriteLine($"{a} / {b} = {q}", a, b, q);
        }
    }
}
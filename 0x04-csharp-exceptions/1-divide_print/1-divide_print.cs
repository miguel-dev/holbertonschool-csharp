using System;

class Int
{
    public static void divide(int a, int b)
    {
        int q = 0;
        try {
            q = a/b;
            Console.WriteLine($"{a} / {b} = {q}", a, b, a/b);
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Cannot divide by zero");
            Console.WriteLine($"{a} / {b} = {q}", a, 0, 0);
        }
    }
}
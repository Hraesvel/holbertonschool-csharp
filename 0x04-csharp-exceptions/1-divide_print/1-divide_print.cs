using System;
using static System.Console;

class Int {
    public static void divide(int a, int b) {
        int c = 0;
        try {
            c = a / b;
        }
        catch (System.DivideByZeroException){
            WriteLine("Cannot divide by zero");
        }
        finally {
            WriteLine("{0} / {1} = {2}", a, b, c);
        }
    }
}
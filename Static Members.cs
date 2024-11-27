using System;

class StaticExample {
    public static int Count = 0;

    public static void Increment() {
        Count++;
        Console.WriteLine("Count: " + Count);
    }
}

class Program {
    static void Main() {
        StaticExample.Increment();
        StaticExample.Increment();
    }
}

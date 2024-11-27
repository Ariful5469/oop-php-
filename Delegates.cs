using System;

delegate void MessageDelegate(string message);

class Program {
    static void PrintMessage(string message) {
        Console.WriteLine(message);
    }

    static void Main() {
        MessageDelegate del = PrintMessage;
        del("Hello, Delegates!");
    }
}

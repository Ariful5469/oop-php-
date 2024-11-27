using System;

class Program {
    static void Main() {
        try {
            int result = 10 / 0;
        } catch (DivideByZeroException e) {
            Console.WriteLine("Error: " + e.Message);
        } finally {
            Console.WriteLine("Execution completed.");
        }
    }
}

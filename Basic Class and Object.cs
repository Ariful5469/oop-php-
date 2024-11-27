using System;

class MyClass {
    public string Name = "C# OOP";

    public void Display() {
        Console.WriteLine("This is " + Name);
    }
}

class Program {
    static void Main() {
        MyClass obj = new MyClass();
        obj.Display();
    }
}

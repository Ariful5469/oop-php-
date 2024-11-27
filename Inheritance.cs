using System;

class ParentClass {
    public virtual void Greet() {
        Console.WriteLine("Hello from Parent");
    }
}

class ChildClass : ParentClass {
    public override void Greet() {
        Console.WriteLine("Hello from Child");
    }
}

class Program {
    static void Main() {
        ChildClass child = new ChildClass();
        child.Greet();
    }
}

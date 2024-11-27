using System;

abstract class Animal {
    public abstract void MakeSound();

    public void Breathe() {
        Console.WriteLine("Breathing...");
    }
}

class Dog : Animal {
    public override void MakeSound() {
        Console.WriteLine("Bark");
    }
}

class Program {
    static void Main() {
        Animal dog = new Dog();
        dog.MakeSound();
        dog.Breathe();
    }
}

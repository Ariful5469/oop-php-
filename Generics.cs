using System;

class GenericExample<T> {
    public T Value;

    public GenericExample(T value) {
        Value = value;
    }

    public void Show() {
        Console.WriteLine("Value: " + Value);
    }
}

class Program {
    static void Main() {
        GenericExample<int> intExample = new GenericExample<int>(10);
        intExample.Show();

        GenericExample<string> stringExample = new GenericExample<string>("Hello");
        stringExample.Show();
    }
}

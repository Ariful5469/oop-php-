using System;

class Singleton {
    private static Singleton instance;

    private Singleton() { }

    public static Singleton Instance {
        get {
            if (instance == null) {
                instance = new Singleton();
            }
            return instance;
        }
    }

    public void ShowMessage() {
        Console.WriteLine("Singleton Instance");
    }
}

class Program {
    static void Main() {
        Singleton single = Singleton.Instance;
        single.ShowMessage();
    }
}

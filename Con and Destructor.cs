using System;

class User {
    private string Name;

    public User(string name) {
        Name = name;
        Console.WriteLine($"User {name} created.");
    }

    ~User() {
        Console.WriteLine($"User {Name} destroyed.");
    }
}

class Program {
    static void Main() {
        User user = new User("John");
    }
}

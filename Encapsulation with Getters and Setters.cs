using System;

class User {
    private string name;

    public string Name {
        get { return name; }
        set { name = value; }
    }
}

class Program {
    static void Main() {
        User user = new User();
        user.Name = "Alice";
        Console.WriteLine(user.Name);
    }
}

using System;

class Example {
    public string PublicVar = "Public";
    private string PrivateVar = "Private";
    protected string ProtectedVar = "Protected";
    internal string InternalVar = "Internal";

    public void Show() {
        Console.WriteLine(PublicVar);
        Console.WriteLine(PrivateVar);
        Console.WriteLine(ProtectedVar);
        Console.WriteLine(InternalVar);
    }
}

class Program {
    static void Main() {
        Example obj = new Example();
        obj.Show();
        Console.WriteLine(obj.PublicVar);
        // Console.WriteLine(obj.PrivateVar); // Error: Inaccessible
    }
}

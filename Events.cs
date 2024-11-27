using System;

class Publisher {
    public event Action OnEvent;

    public void TriggerEvent() {
        OnEvent?.Invoke();
    }
}

class Subscriber {
    public void Respond() {
        Console.WriteLine("Event triggered!");
    }
}

class Program {
    static void Main() {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber();

        publisher.OnEvent += subscriber.Respond;
        publisher.TriggerEvent();
    }
}

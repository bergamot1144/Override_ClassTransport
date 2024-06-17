

TransportManager manager = new TransportManager();

Car car = new Car("Toyota", "Camry", "Sedan");
Bicycle bicycle = new Bicycle("Trek", "Domane", "Road Bike");
Airplane airplane = new Airplane("Boeing", "737");

manager.AddTransport(car);
manager.AddTransport(bicycle);
manager.AddTransport(airplane);

manager.ManageTransports();
    
class TransportManager
{
    private List<Transport> transports = new List<Transport>();

    public void AddTransport(Transport transport)
    {
        transports.Add(transport);
    }

    public void ManageTransports()
    {
        foreach (var transport in transports)
        {
            transport.Move();
        }

        foreach (var transport in transports)
        {
            transport.Stop();
        }
    }
}
class Car : Transport
{
    public string Type { get; set; }
    public string Model { get; set; }

    public Car(string name, string model, string type) : base(name)
    {
        Model = model;
        Type = type;
    }

    public override void Move()
    {
        Console.WriteLine($"Car - {Type}\nName: {Name} \nModel: {Model}\nSTART TO MOVE");
    }

    public override void Stop()
    {
        Console.WriteLine($"{Name} \nModel: {Model}\nSTOPPED");
    }
}
class Bicycle : Transport
{
    public string Type { get; set; }
    public string Model { get; set; }

    public Bicycle(string name, string model, string type) : base(name)
    {
        Model = model;
        Type = type;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} \t {Model}\t START TO MOVE");
    }

    public override void Stop()
    {
        Console.WriteLine($"{Name} \t Model: {Model}\t STOPPED");
    }
}
class Airplane : Transport
{
    public string Type { get; set; }

    public Airplane(string name, string type) : base(name)
    {
        Type = type;
    }

    public override void Move()
    {
        Console.WriteLine($"Airplane - {Name} {Type} START TO MOVE");
    }

    public override void Stop()
    {
        Console.WriteLine($"Airplane - {Name} {Type} STOPPED");
    }
}

class Transport
{
    public string Name { get; set; }

    public Transport(string name)
    {
        Name = name;
    }

    public virtual void Move()
    {
        Console.WriteLine($"Transport {Name} start to move");
    }

    public virtual void Stop()
    {
        Console.WriteLine($"Transport {Name} stopped");
    }
}


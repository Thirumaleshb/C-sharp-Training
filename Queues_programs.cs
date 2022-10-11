// See https://aka.ms/new-console-template for more information
class Passenger
{
    public  string name;
    public string Destination;
    public  static int count = 0;

    public Passenger(string name, string destination)
    {
        this.name = name;
        this.Destination = destination;
        count++;
    }

    public override string ToString()
    {
        return $"The Passenger Number {count} {this.name} is travelling to {this.Destination}";
    }
}
class bus
{
    public const int capacity = 10;
    Queue<Passenger>queue=new Queue<Passenger>();

    public int space { get => capacity - (Passenger.count); }

    public void Load(Passenger passenger)
    {
        if(space>0)
        {
            queue.Enqueue(passenger);

        }
    }

    public int Numberofpassenger()
    {
        return space;
    }

    public void unload(int num)
    {
        //while (space != 0)
            for (int i = 0; i < num; i++)
        {
            Passenger passengerGetdown = queue.Dequeue();
            Console.WriteLine("The Passenger who got down is " + passengerGetdown.name);
            Passenger.count--;

        }
        

    }
}
class program
{
    public static void Main(string[] args)
    {
        Passenger p1 = new Passenger("Thiru", "Bangalore");
        Passenger p2 = new Passenger("Manoj", "Hyderabad");
        bus b1 = new bus();
        b1.Load(p1);
        b1.Load(p2);
       Console.WriteLine(b1.Numberofpassenger());
        Console.WriteLine(Passenger.count);
        b1.unload(1);
        Console.WriteLine(Passenger.count);

    }
}

// See https://aka.ms/new-console-template for more informationc
using System.Runtime.Intrinsics.X86;

class BusRoute
{
    public int Km;
    public string startpoint;
    public string endpoint;
    //private string[] times;

    public BusRoute(int km, string startpoint, string endpoint )
    {
        this.Km = km;
        this.startpoint = startpoint;
        this.endpoint = endpoint;
        //this.times = times;
    }

    public override string ToString()
    {
        return $" From {this.startpoint}-> {this.endpoint} the distance is {this.Km}";
    }

}

class Collection_Program
{
    public static void Main(string[] args)
    {
       BusRoute B1 = new BusRoute(150, "Bangalore", "Mysore");
       BusRoute B2 = new BusRoute(250, "Bangalore", "Hyderabad");
       String[][] timings =
        {
            new string[]{"15:00","19:00" },
           new string[]{"17:30","21:30" }
        };


        BusRoute[] Buses = { B1, B2 };

        Array.Resize(ref Buses, 2);
       
        foreach (var item in Buses)
        {
            Console.WriteLine(item);
        }

        Array.FindAll(Buses, Bus => Bus.endpoint.Length<10);

        BusRoute[] objec=Array.FindAll(Buses, Bus => Bus.startpoint == "Bangalore");
        Console.WriteLine(objec.Length);

        Console.WriteLine("The Length of the timing is " + timings.Length);
        foreach (var item in timings)
        {
            Console.WriteLine(item);
        }

        for(int i = 0; i < Buses.Length; i++)
        {
            for (int j = 0; j < timings.Length; j++)
            {
               // string  v = timings[i,j];
               // Console.WriteLine($"The Depature Timings of Journey {i + 1} from {Buses[i].startpoint} is {timings[i, j]} and it will Reach {Buses[i].endpoint} at {timings[i,j+1]}");
            }
        }
        // Console.WriteLine(B1);
        //onsole.WriteLine(B2);\
         



        //Working With List
        Console.WriteLine("Creating List Methods");
        List<BusRoute> list=new List<BusRoute>();
        list.Add(B1);
        list.Add(B2);
        list.Add(new BusRoute(120, "Bangalore", "Hindupur"));

        Console.WriteLine(list.Count());


        list.RemoveAll(ele => ele.startpoint.StartsWith("Bangalore"));


        Console.WriteLine(list.Count());


        //Working with Dictionary

        Dictionary<int, BusRoute> route = new Dictionary<int, BusRoute>();
        route.Add(150,B1);
        route.Add(250,B2);
        Console.WriteLine(route);

        foreach (var rro in route.Keys) 
        {
            Console.WriteLine(rro);
        }

        foreach (var rro in route.Values)
        {
            Console.WriteLine(rro);
        }

        foreach (var rro in route.Keys)
        {
            Console.WriteLine(rro);
        }




        //MultiDimensional Data









    }
}
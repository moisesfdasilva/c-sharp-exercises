class Program
{
  static void Main(string[] args)
  {
    Character someone = new Character();
    Plane somePlane = new Plane();

    IAction adapter = new Adapter(somePlane);

    Console.WriteLine("--- WALKING ---");
    someone.Walk("Someone");
    someone.Shoot();

    Console.WriteLine("--- GOT A PLANE ---");
    adapter.Walk("Someone");
    adapter.Shoot();
  }
}
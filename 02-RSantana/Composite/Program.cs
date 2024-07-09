class Program
{
  static void Main(string[] args)
  {
    Composite map = new Composite("MAP OF CAVES");

    Composite cave1 = new Composite("Cave 1");
    cave1.Add(new GameMap("Sub Map 1"));
    cave1.Add(new GameMap("Sub Map 2"));
    cave1.Add(new GameMap("Sub Map 3"));

    Composite cave2 = new Composite("Cave 2");
    cave2.Add(new GameMap("Sub Map 4"));
    cave2.Add(new GameMap("Sub Map 5"));

    Composite secretDoor = new Composite("Secret Door");
    secretDoor.Add(new GameMap("Sub Map Secret X"));

    map.Add(cave1);
    map.Add(cave2);
    cave2.Add(secretDoor);

    map.Show(1);
  }
}

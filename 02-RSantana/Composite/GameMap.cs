public class GameMap : MapComponent
{
  public GameMap(string name) : base(name)
  {
  }
  public override void Add(MapComponent c)
  {
    Console.WriteLine("Can't add map of game here.");
  }
  public override void Remove(MapComponent c)
  {
    Console.WriteLine("Can't add map of game here.");
  }
  public override void Show(int depth)
  {
    Console.WriteLine(new string('-', depth) + name);
  }
}
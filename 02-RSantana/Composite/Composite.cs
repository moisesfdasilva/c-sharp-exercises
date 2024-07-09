public class Composite : MapComponent
{
  private List<MapComponent> gamesMap = new List<MapComponent>();
  public Composite(string name) : base(name)
  {

  }
  public override void Add(MapComponent c)
  {
    this.gamesMap.Add(c);
  }
  public override void Show(int depth)
  {
    Console.WriteLine(new string('-', depth) + name);

    foreach (MapComponent item in this.gamesMap)
    {
      item.Show(depth + 2);
    }
  }
  public override void Remove(MapComponent c)
  {
    this.gamesMap.Remove(c);
  }
}
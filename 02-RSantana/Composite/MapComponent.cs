public abstract class MapComponent
{
  protected string name;
  public MapComponent(string name)
  {
    this.name = name;
  }
  public abstract void Add(MapComponent c);
  public abstract void Remove(MapComponent c);
  public abstract void Show(int depth);
}
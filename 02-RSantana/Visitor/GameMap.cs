public class GameMap : IGame
{
  public string MapName { get; set; }
  public void Visitor(IVisitor visitor)
  {
    visitor.Identification(this);
  }
}
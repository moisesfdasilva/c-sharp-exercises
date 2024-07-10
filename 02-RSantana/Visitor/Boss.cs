public class Boss : IGame
{
  public string BossName { get; set; }
  public int LifePoints { get; set; }

  public void Visitor(IVisitor visitor)
  {
    visitor.Identification(this);
  }
}
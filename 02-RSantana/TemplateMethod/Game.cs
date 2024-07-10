public abstract class Game
{
  public Game()
  {
    Soundtrack();
    FirstMap();
    SecondMap();
  }
  public abstract void FirstMap();
  public abstract void SecondMap();
  private void Soundtrack()
  {
    Console.WriteLine("Amazing music");
  }
}

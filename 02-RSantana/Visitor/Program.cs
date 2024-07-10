class Program
{
  static void Main(string[] args)
  {
    List<IGame> game = new List<IGame>();
    game.Add(new GameMap() { MapName = "Forest" });
    game.Add(new GameMap() { MapName = "Cave" });
    game.Add(new Boss() { BossName = "Boss 1" });
    game.Add(new Boss() { BossName = "Boss 2" });

    VisitorLevel level = new VisitorLevel();
    foreach(var e in game)
    {
      e.Visitor(level);
    }
  }
}

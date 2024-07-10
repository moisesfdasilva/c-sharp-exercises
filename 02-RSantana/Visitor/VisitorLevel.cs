public class VisitorLevel : IVisitor
{
  public void Identification(GameMap gameMap)
  {
    switch (gameMap.MapName)
    {
      case "Forest":
        Console.WriteLine("The map {0} is {1}% difficult.",
          gameMap.MapName, 70);
        break;
      case "Cave":
        Console.WriteLine("The map {0} is {1}% difficult.",
          gameMap.MapName, 30);
        break;
    }
  }
  public void Identification(Boss boss)
  {
    switch (boss.BossName)
    {
      case "Boss 1":
        Console.WriteLine(
          "The boss {0} is {1}% difficult, and have {2} of life",
          boss.BossName, 25, boss.LifePoints);
        break;
      case "Boss 2":
        Console.WriteLine(
          "The boss {0} is {1}% difficult, and have {2} of life",
          boss.BossName, 50, boss.LifePoints);
        break;
    }
  }
}
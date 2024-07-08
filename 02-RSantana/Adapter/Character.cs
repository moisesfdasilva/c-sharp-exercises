public class Character : IAction
{
  public void Shoot()
  {
    Console.WriteLine("The character shooted in the game.");
  }
  public void Walk(string character)
  {
    Console.WriteLine($"The {character} went to ahead.");
  }
}
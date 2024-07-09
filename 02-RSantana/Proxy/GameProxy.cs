public class GameProxy : IMap
{
  GameMap gameMap;
  string password = "123";
  public string Play()
  {
    if (this.gameMap != null)
      return gameMap.Play();

    return "Enter the password.";
  }
  public string VerifyPassword(string pass)
  {
    if (pass == this.password)
    {
      this.gameMap = new GameMap();
      return "Correct Password!";
    }
    return "Password wrong!";
  }
}
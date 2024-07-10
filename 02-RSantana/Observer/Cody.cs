public class Cody : ICharacter
{
  private List<IObserver> enemies = new List<IObserver>();
  public int life = 100;
  public void InformCharacters()
  {
    foreach (IObserver enemy in enemies)
    {
      enemy.Alert(this);
    }
  }
  public void ObserverRegister(IObserver i)
  {
    enemies.Add(i);
  }
  public void RightHit(bool hit)
  {
    if (hit)
      life -= 10;

    InformCharacters();
  }
  public int getLife()
  {
    return life;
  }
}
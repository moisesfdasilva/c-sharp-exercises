public abstract class Player
{
  protected Mediator mediator;

  public Player(Mediator mediator)
  {
    this.mediator = mediator;
  }
}
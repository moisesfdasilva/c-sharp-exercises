public class Player1 : Player
{
  public Player1(Mediator mediator) : base(mediator) {}

  public void Send(string message)
  {
    mediator.Send(message, this);
  }

  public void Notify(string message)
  {
    Console.WriteLine("Message of player 1: " + message);
  }
}
public class Player2 : Player
{
  public Player2(Mediator mediator) : base(mediator) {}

  public void Send(string message)
  {
    mediator.Send(message, this);
  }

  public void Notify(string message)
  {
    Console.WriteLine("Message of player 2: " + message);
  }
}
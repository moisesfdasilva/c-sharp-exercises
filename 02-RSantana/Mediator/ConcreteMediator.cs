public class ConcreteMediator : Mediator
{
  private Player1 player1;
  private Player2 player2;
  
  public Player1 Player1
  {
    set { player1 = value; }
  }

  public Player2 Player2
  {
    set { player2 = value; }
  }

  public override void Send(string message, Player player)
  {
    if (player == player2)
      player1.Notify(message);
    else
      player2.Notify(message);
  }
}
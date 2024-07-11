class Program
{
  static void Main(string[] args)
  {
    ConcreteMediator mediator = new ConcreteMediator();

    Player1 player1 = new Player1(mediator);
    Player2 player2 = new Player2(mediator);

    mediator.Player1 = player1;
    mediator.Player2 = player2;

    player1.Send("This game was amazing!");
    player2.Send("Yes, it was an excellent game.");
  }
}

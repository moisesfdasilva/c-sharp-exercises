namespace Singletonn
{
  class Program
  {
    static void Main(string[] args)
    {
      Singleton player_1 = Singleton.GetInstance;
      player_1.Message("Player 1: The ball is with me in middle of the field.");
    }
  }
}
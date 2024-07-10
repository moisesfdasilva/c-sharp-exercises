class Program
{
  static void Main(string[] args)
  {
    Cody cody = new Cody();

    Enemy enemy1 = new Enemy(cody);
    Enemy enemy2 = new Enemy(cody);
    Enemy enemy3 = new Enemy(cody);

    bool gameOn = true;

    while(gameOn)
    {
      Console.WriteLine("Hit Cody, yes(y) or not(n)?");
      if (Console.ReadLine() == "y")
      {
        cody.RightHit(true);
        gameOn = (cody.getLife() > 0) ? gameOn : false;
      }
      else
      {
        Console.WriteLine("You don't hit Cody!");
      }
    }
  }
}

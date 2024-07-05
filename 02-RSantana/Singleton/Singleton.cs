class Singleton
{
  private static Singleton instance = null;
  public static Singleton GetInstance
  {
    get
    {
      if (instance == null)
      {
        instance = new Singleton();
        Console.WriteLine("Ball into game");
      }
      return instance;
    }
  }
  public void Message(string msg)
  {
    Console.WriteLine(msg);
  }
}
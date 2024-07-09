class Program
{
  static void Main(string[] args)
  {
    // Console.WriteLine("### Going to the map without Proxy ###");
    // GameMap game = new GameMap();
    // Console.WriteLine(game.Play());

    GameProxy proxy = new GameProxy();

    Console.WriteLine("### Trying go to the map with wrong passord ###");
    Console.WriteLine(proxy.VerifyPassword("465"));
    Console.WriteLine(proxy.Play());

    Console.WriteLine("------");
    
    Console.WriteLine("### Trying go to the map with correct passord ###");
    Console.WriteLine(proxy.VerifyPassword("123"));
    Console.WriteLine(proxy.Play());
  }
}

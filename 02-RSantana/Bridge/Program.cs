class Program
{
  static void Main(string[] args)
  {
    Bridge bridge = new Bridge();
    Random random = new Random();

    void Raffle()
    {
      if (random.Next(2) == 1)
      {
        bridge.selected_shape = new Shape1();
      }
      else
      {
        bridge.selected_shape = new Shape2();
      }

      if (random.Next(1, 3) == 1)
      {
        bridge.selected_shape.IColor = new Green();
      }
      else if (random.Next(1, 3) == 2)
      {
        bridge.selected_shape.IColor = new Orange();
      }
      else
      {
        bridge.selected_shape.IColor = new Pink();
      }
    }

    Console.WriteLine("Press ENTER to send a new shape.");

    while (1 > 0)
    {
      ConsoleKeyInfo input = Console.ReadKey();
      if (input.KeyChar == 13)
      {
        Raffle();
      }
      bridge.ShowShape();
    }
  }
}

public class OutParameters
{
  public static void RunOutParameters()
  {
    int num = 0;
    bool success = test(out num);
    Console.WriteLine(num); // 5
    Console.WriteLine(success);
  }

  static bool test(out int num)
  {
    num = 5;
    return true;
  }
}
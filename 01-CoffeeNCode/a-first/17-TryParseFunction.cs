public class TryParseFunction
{
  public void runTryParseFunction()
  {
    Console.Write("value: ");
    string numInput = Console.ReadLine(); //10h
    int num = 0;

    bool sucess = int.TryParse(numInput, out num);

    if (sucess)
    {
      Console.WriteLine("value: ");
    }
    else
    {
      Console.WriteLine("Failed to convert!");
    }
  }
}

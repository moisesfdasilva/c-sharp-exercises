public class TimesTable
{
  public void runTimesTable()
  {
    // Ask the user for a number for table
    // Write a for loop to print x times

    Console.Write("Enter a number to repeat 'x' times: ");
    string inputA = Console.ReadLine();
    Console.Write("Enter a number to 'x': ");
    string inputB = Console.ReadLine();
    int num = 0;

    bool aSuccess = int.TryParse(inputA, out num);
    bool bSuccess = int.TryParse(inputB, out num);

    if (aSuccess && bSuccess)
    {
      int numB = Convert.ToInt32(inputB);
      for(int i = 0; i <= numB; i += 1)
      {
        int numA = Convert.ToInt32(inputA);
        Console.WriteLine("{0} x {1} = {2}", i, numA, i * numA);
      }
    }
    else
    {
      Console.Write("Failed to convert!");
    }
  }
}

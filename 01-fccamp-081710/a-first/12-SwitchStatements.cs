public class SwitchStatements
{
  public void runSwitchStatements()
  {
    Console.Write("Enter a day of the week: ");
    int day = Convert.ToInt32(Console.ReadLine());

    // if (day == 1)
    // {
    //   Console.WriteLine("Mon");
    // }
    // else if (day == 2)
    // {
    //   Console.WriteLine("Tue");
    // } ...

    switch (day)
    {
      case 1: Console.WriteLine("Mon");
        break;
      case 2: Console.WriteLine("Tue");
        break;
      case 3: Console.WriteLine("Wed");
        break;
      case 4: Console.WriteLine("Thu");
        break;
      case 5: Console.WriteLine("Fri");
        break;
      case 6: Console.WriteLine("Sat");
        break;
      case 7: Console.WriteLine("Sun");
        break;
      default: Console.WriteLine("Invalid, enter a value between 1 and 7.");
        break;
    }
  }
}

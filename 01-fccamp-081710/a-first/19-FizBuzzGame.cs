public class FizBuzzGame
{
  public void runFizBuzzGame()
  {
    /* Create a for loop from 1 to X (15)
     3 and 5 = FizzBuzz
     3 = Fizz
     5 = Buzz
     else = number
    */
    
    Console.Write("Enter with a number of loops: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int i = 1;
    while (i <= n)
    {
      bool fizz = (i % 3 == 0) ? true : false;
      bool buzz = (i % 5 == 0) ? true : false;

      if (fizz && buzz)
      {
        Console.WriteLine("FizzBuzz");
      }
      else if (fizz)
      {
        Console.WriteLine("Fizz");
      }
      else if (buzz)
      {
        Console.WriteLine("Buzz");
      }
      else
      {
        Console.WriteLine(i);
      }
      i++;
    }
  }
}

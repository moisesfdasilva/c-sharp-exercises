public class OddEvenNumbers
{
  public void runOddEvenNumbers()
  {
    /*
    Create two lists with integer data type, one for even numbers,
    and one for odd
    Loop from 0-20
      if number is even, add to even list
      is number is odd, add to odd list
    Print even list
    Print odd list
    */

    List<int> evenNums = new List<int>();
    List<int> oddNums = new List<int>();

    int i = 0;
    while (i <= 20)
    {
      if (i % 2 == 0)
      {
        evenNums.Add(i);
      }
      else
      {
        oddNums.Add(i);
      }
      i++;
    }

    foreach (int num in evenNums)
    {
      Console.WriteLine(num);
    }

    foreach (int num in oddNums)
    {
      Console.WriteLine(num);
    }
  }
}
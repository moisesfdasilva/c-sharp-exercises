public class ArrayReversal
{
  public void runArrayReversal()
  {
    int[] numbers = new int[]
    {
      0, 1, 2, 3, 4, 5
    };

    Array.Reverse(numbers);

    foreach (int num in numbers)
    {
      Console.Write($"{num} ");
    }
  }
}
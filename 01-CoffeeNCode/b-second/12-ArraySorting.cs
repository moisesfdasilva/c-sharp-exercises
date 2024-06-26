public class ArraySorting
{
  public void runArraySorting()
  {
    int[] numbers = new int[]
    {
      9, 2, 0, 5, 5, 6, 7, 8, 9
    };

    Array.Sort(numbers);

    foreach (int num in numbers)
    {
      Console.Write($"{num} ");
    }
  }
}
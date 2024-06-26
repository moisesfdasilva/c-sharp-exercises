public class ArrayClearing
{
  public void runArrayClearing()
  {
    int[] numbers = new int[]
    {
      0, 1, 2, 3, 4, 5, 6, 7, 8, 9
    };

    // Array.Clear(numbers, 0, numbers.Length);
    Array.Clear(numbers, 5, 5);

    for (int i = 5; i < 10; i++)
    {
      numbers[i] = default;
    }
    
    foreach (int num in numbers)
    {
      Console.Write($"{num} ");
    }
  }
}
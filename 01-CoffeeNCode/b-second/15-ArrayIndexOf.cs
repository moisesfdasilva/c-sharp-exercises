public class ArrayIndexOf
{
  public void runArrayIndexOf()
  {
    int[] numbers = new int[]
    {
      90, 199, 22, 50, 30
    };

    Console.Write("Enter number to search: ");
    int search = Convert.ToInt32(Console.ReadLine());

    //int position = Array.IndexOf(numbers, search);
    //position = Array.IndexOf(numbers, search, 2);
    int position = Array.IndexOf(numbers, search, 1, 2);

    if (position > -1)
    {
      Console.WriteLine($"Number {search} has been found at position {position + 1}.");
    }
    else
    {
      Console.WriteLine($"Number {search} has not been found.");
    }
  }
}
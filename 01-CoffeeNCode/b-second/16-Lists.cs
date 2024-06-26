public class Lists
{
  public void runLists()
  {
    int[] numbers = new int[3]
    {
      1, 2, 3
    };

    // List<int> listNumbers = new List<int>()
    // {
    //   1, 2, 3, 4, 5, 6, 7
    // };
    // listNumbers.Add(1);
    // listNumbers.Add(2);

    List<int> listNumbers = new List<int>();

    for (int i = 0; i < 3; i++)
    {
      Console.Write("Enter a number: ");
      listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
    }

    listNumbers.RemoveAt(0);

    foreach(int num in listNumbers)
    {
      Console.WriteLine(num);
    }
  }
}
public class ArrayOfMultiples
{
  public void runArrayOfMultiples()
  {
    /*
    Define and initialise two integers (num, length)
    (7, 5) -> [7, 14, 21, 28, 35]
    Create int array with size length
    loop throught and insert the (loop counter x num) into the array
    print the final array
    */

    int num = 7;
    int length = 5;

    int[] numbers = new int[length];

    for (int i = 1; i <= length; i += 1)
    {
      numbers[i - 1] = i * num;
    }

    foreach (int item in numbers)
    {
      Console.WriteLine(item);
    }
  }
}
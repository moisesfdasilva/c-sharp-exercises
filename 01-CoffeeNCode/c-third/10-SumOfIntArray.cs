public class SumOfIntArray
{
  /*
  Create and initialize int array of numbers
  Create function SumOfNumbers with int return type
  int array
  function should return total of all numbers
  call in main and output the total
  extra:
    check array length
    return -1 if array empty
    check return in main and output message
    do we need to return -1, how else can we make this?
  */
  public static void RunSumOfIntArray()
  {
    int[] nums = new int[5]
    {
      25, 50, 75, 100, 125
    };

    Console.WriteLine($"The sum of array is: {SumOfNumbers(numbers: nums)}");
    Console.WriteLine($"The length of array is: {LengthOfArray(numbers: nums)}");
  }

  static int SumOfNumbers(int[] numbers)
  {
    int sum = 0;
    foreach(int number in numbers)
    {
      sum += number;
    }
    return sum;
  }
  static int LengthOfArray(int[] numbers)
  {
    int length = -1;
    // if the array is numbers[5] without values the length is 5.
    if (numbers.Length > 0) {
      length = numbers.Length;
    }
    return length;
  }
}
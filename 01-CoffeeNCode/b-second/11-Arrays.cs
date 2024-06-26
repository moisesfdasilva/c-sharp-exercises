public class Arrays
{
  public void runArrays()
  {
    int[] numbers = new int[3];

    numbers[0] = 5;
    numbers[1] = 10;
    numbers[2] = 15;

    Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

    int[] angles = new int[3];

    for (int i = 0; i <angles.Length; i++)
    {
      Console.WriteLine($"Enter a angle {i + 1}: ");
      angles[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    int angleSum = 0;

    foreach (int angle in angles)
    {
      angleSum += angle;
    }

    Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");
  }
}
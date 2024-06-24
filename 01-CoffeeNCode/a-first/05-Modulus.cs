public class Modulus
{
  public void runModulus()
  {
    int firstNum = 10;
    int secondNum = 3;

    // (10 / 3) = 3r1
    // 3 x 3 = 9, 1 left over to get to 10

    // 10 % 2 = 0
    // 11 % 2 = 1
    // 12 % 2 = 0
    // 13 % 2 = 1

    Console.WriteLine(firstNum % secondNum);
  }
}

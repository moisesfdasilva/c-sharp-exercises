public class StringInterpolation
{
  public void runStringInterpolation()
  {
    string name = "Moshe";
    int age = 27;

    Console.WriteLine("Your name is " + name + ", and your age is " + age);
    Console.WriteLine($"Your name is {name}, and your age is {age}");
  }
}
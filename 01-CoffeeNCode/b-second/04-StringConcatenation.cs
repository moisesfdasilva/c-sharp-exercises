public class StringConcatenation
{
  public void runStringConcatenation()
  {
    string name = "Moshe";
    int age = 27;

    Console.WriteLine("Your name is " + name + ", and your age is " + age);
    Console.WriteLine($"Your name is {name}, and your age is {age}");
    Console.WriteLine("Your name is {0}, and your age is {1}", name, age);

    string test = string.Concat("Your name is ", name, ", and your age is ", age);
  }
}
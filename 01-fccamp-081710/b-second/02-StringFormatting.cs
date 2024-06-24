public class StringFormatting
{
  public void runStringFormatting()
  {
    string name = "Moshe";
    int age = 27;

    Console.WriteLine("Name: " + name);
    Console.WriteLine("Age: " + age);

    Console.WriteLine("Name: " + name + "\nAge" + age);

    Console.WriteLine("Your name is " + name + ", and your age is " + age);

    Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
    Console.WriteLine("Name: {0}\nAge: {1}", name, age);
  }
}
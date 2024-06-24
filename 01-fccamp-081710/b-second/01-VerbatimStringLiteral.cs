public class VerbatimStringLiteral
{
  public void runVerbatimStringLiteral()
  {
    // \t \n \"
    string speech = "He said \"something\"";
    string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course\nNew line test";
    Console.WriteLine(speech);
    Console.WriteLine(path);

    // $
    // $"Your name is {name}"
    string name = "Moshe";
    Console.WriteLine($"Your name is {name}");

    path = @"C:\Users\CoffeeNCode\Desktop\C# Course" + "\nNew Line Test";
    Console.WriteLine(path);

    name = @"Hello ""someone""";
    Console.WriteLine(name);

    name = "Hello 'someone'";
    Console.WriteLine(name);
  }
}
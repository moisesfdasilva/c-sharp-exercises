public class Dictionaries
{
  public void runDictionaries()
  {
    Dictionary<int, string> names = new Dictionary<int, string>();

    names.Add(1, "Moshe");
    names.Add(2, "Mouses");
    names.Add(3, "Musa");
    names.Add(4, "Moses");

    for (int i = 0; i < names.Count; i++)
    {
      KeyValuePair<int, string> pair = names.ElementAt(i);
      Console.WriteLine($"{pair.Key} - {pair.Value}");
    }

    Console.WriteLine("______________________________________");

    Dictionary<string, string> moses = new Dictionary<string, string>
    {
      { "hebrew", "Moshe" },
      { "greech", "Mouses" },
      { "arabic", "Musa" },
      { "english", "Moses" }
    };

    // Console.WriteLine(moses["Hebrew"]); // TryParse Convert

    if (moses.TryGetValue("Hebrew", out string name))
    {
      Console.WriteLine(name);
    }
    else
    {
      Console.WriteLine("Hebrew not found");
    }

    if (moses.ContainsKey("Hebrew"))
    {
      moses.Remove("Hebrew");
    }
    else
    {
      Console.WriteLine("Hebrew not found");
    }

    foreach (KeyValuePair<string, string> item in moses)
    {
      Console.WriteLine($"{item.Key} - {item.Value}");
    }
  }
}
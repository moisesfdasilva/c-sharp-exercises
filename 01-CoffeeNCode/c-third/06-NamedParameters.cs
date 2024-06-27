public class NamedParameters
{
  public static void RunNamedParameters()
  {
    string nameInput = "Moshe";
    int ageInput = 27;
    string addressInput = "15th Street";

    PrintDetails(name: nameInput,
      age: ageInput,
      address: addressInput);
  }

  static void PrintDetails(string name, int age, string address)
  {
    Console.WriteLine($"Name: {name}.");
    Console.WriteLine($"Age: {age}.");
    Console.WriteLine($"Address: {address}.");
  }
}
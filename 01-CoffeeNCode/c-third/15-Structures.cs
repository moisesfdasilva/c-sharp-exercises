public class Structures
{
  struct Person
  {
    public string name;
    public int age;
    public int birthMonth;
    public int number;
    public Person(string name, int age, int birthMonth, int number)
    {
      this.name = name;
      this.age = age;
      this.birthMonth = birthMonth;
      this.number = number;
    }
  }
  public static void RunStructures()
  {
    Person person = new Person(name: "Moshe", age: 27, birthMonth: 3, number: 12);
    
    Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth} - {person.number}");
  }
}
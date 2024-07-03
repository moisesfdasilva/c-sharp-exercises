public class ClassProperties
{
  class Person
  {
    private string name;
    private int age;

    public string Name
    {
      get => name;
      set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
    }
    public int Age
    {
      get => age;
      set => age = value >= 0 && value <= 150 ? value : -1;
    }

    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;

      Name = name;
      Age = age;
    }
    public string RunDetails()
    {
      return $"Name: {Name}\nAge: {Age}";
    }
  }
    class PersonB
    {
      public string Name { get; set; }
      public int Age { get; set; }

      public PersonB(string name, int age)
      {
        Name = name;
        Age = age;
      }
    }
  public static void RunClassProperties()
  {
    Person person = new Person(name: "Moshe", age: 27);
    Console.WriteLine(person.RunDetails());

    person.Name = "Moises";
    person.Age = 35;
    Console.WriteLine(person.RunDetails());

    PersonB personB = new PersonB(name: "Azrael", age: 18);
    Console.WriteLine($"The name is {personB.Name} and age is {personB.Age}");

    personB.Name = "Anael";
    personB.Age = 19;
    Console.WriteLine($"The name is {personB.Name} and age is {personB.Age}");
  }
}

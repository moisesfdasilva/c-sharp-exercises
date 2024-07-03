public class ClassToStringOverride
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
    // public string RunDetails()
    // {
    //   return $"Name: {Name}\nAge: {Age}";
    // }
    public override string ToString()
    {
      return $"Name: {Name}\nAge: {Age}";
    }
    public override bool Equals(object obj)
    {
      try
      {
        Person person = obj as Person;
        return Name.Equals(person.Name) && Age == person.Age;
      }
      catch
      {
        return false;
      }
    }
  }
  public static void RunClassToStringOverride()
  {
    Person personA = new Person(name: "Azrael", age: 18);
    Person personB = new Person(name: "Azrael", age: 18);

    if (personA.Equals(personB))
    {
      Console.WriteLine("Same.");
    }
    else
    {
      Console.WriteLine("Not same.");
    }
  }
}

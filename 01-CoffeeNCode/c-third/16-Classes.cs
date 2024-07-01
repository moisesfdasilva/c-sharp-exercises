public class Classes
{
  class Person
  {
    public string name;
    public int age;

    public Person()
    {
    }
    public Person(string name)
    {
      this.name = name;
      this.age = -1;
    }
    public Person(int age)
    {
      this.age = age;
      this.name = "";
    }
    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;
    }
  }
  public static void RunClasses()
  {
    Person personA = new Person();
    personA.name = "Moshe A.";
    personA.age = 2;

    Person personB = new Person(name: "Moshe B.");
    personB.age = 12;

    Person personC = new Person(age: 22);
    personC.name = "Moshe C.";

    Person personD = new Person(name: "Moshe D.", age: 32);

    Person[] persons = new Person[4]
    {
      personA, personB, personC, personD
    };

    foreach(Person p in persons)
    {
      Console.WriteLine($"{p.name} - {p.age}");
    }
  }
}

public class ClassVariable
{
  class Person
  {
    private string name;
    private int age;
    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;
    }
    public void SetName(string name)
    {
      this.name = (!string.IsNullOrEmpty(name)) ? name : "Invalid name";
    }
    public string GetName()
    {
      return name;
    }
    public void SetAge(int age)
    {
      this.age = (age >= 0 && age <= 150) ? age : -1;
    }
    public int GetAge()
    {
      return age;
    }
    public string RunDetails()
    {
      return $"Name: {name}\nAge: {age}";
    }
  }
  public static void RunClassVariable()
  {
    Person person = new Person(name: "Moshe", age: 27);
    person.SetName("Moses");
    person.SetAge(25);
    Console.WriteLine(person.RunDetails());
  }
}

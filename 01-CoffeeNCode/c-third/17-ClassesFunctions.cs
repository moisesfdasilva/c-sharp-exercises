public class ClassesFunctions
{
  class Person
  {
    public string name;
    public int age;
    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;
    }
    public string ReturnDetails()
    {
      return $"Name: {this.name};\nAge: {this.age}.";
    }
  }
  public static void RunClassesFunctions()
  {
    Person person = new Person(name: "Moshe", age: 27);
    Console.WriteLine(person.ReturnDetails());
  }
}

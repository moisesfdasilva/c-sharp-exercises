public class Operations
{
  public void runOperations()
  {
    int age = 23;
    
    age++;
    Console.WriteLine(age);
    age--;
    Console.WriteLine(age);

    age = age + 1;
    Console.WriteLine(age);
    age = age - 1;
    Console.WriteLine(age);

    age += 1;
    Console.WriteLine(age);
    age -= 1;
    Console.WriteLine(age);

    age *= 10;
    Console.WriteLine(age);
    age /= 10;
    Console.WriteLine(age);

    string name = "Aba";
    name += " is programming";
    Console.WriteLine(name);
    // name -= " is programming"; -----> DON'T WORKING

    char ch = 'a';
    ch += 'b';
    Console.WriteLine(ch); // return (U+0061 + U+0062) = U+00C3

    int i = 0;
    i++;
    Console.WriteLine(i); // return 1
  }
}

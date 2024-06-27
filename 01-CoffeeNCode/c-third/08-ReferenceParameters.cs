public class ReferenceParameters
{
  public static void RunReferenceParameters()
  {
    int num = 10; //1
    string name = "Joe";
    Assign(ref num, ref name);
    Console.WriteLine(num);
    Console.WriteLine(name);
  }

  static void Assign(ref int num, ref string name) //1
  {
    name = "Aba";
    num = 20;
  }
}
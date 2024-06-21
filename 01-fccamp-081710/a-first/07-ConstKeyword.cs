public class ConstKeyword
{
  public void runConstKeyword()
  {
    const int vat = 20; 
    // vat = 10; -----> DON'T WORKING
    
    const double percentVat = vat / 1000D;

    int balance = 1000;

    Console.WriteLine(balance * percentVat);

    const string version = "v1.0";
    Console.WriteLine(version);
  }
}

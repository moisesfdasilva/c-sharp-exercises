public class PasswordChecker
{
  public void runPasswordChecker()
  {
    /*
    1- Ask user to enter password, and store
    2- Ask user to enter password again, and store
    3- Check if they are both contain something
      - If so check if they are the same
        - If they are, print "Password math"
        - If they are not, print "Password not match"
      - If they are empty, print "Please enter a password."
    */

    Console.Write("Enter your password: ");
    string passA = Console.ReadLine();

    Console.Write("Enter your password again: ");
    string passB = Console.ReadLine();

    if (string.IsNullOrEmpty(passA) | string.IsNullOrEmpty(passB))
    {
      Console.WriteLine("Please enter a password");
    }
    else
    {
      if (passA.Equals(passB))
      {
        Console.WriteLine("Password math");
      }
      else
      {
        Console.WriteLine("Password not match");
      }
    }
  }
}
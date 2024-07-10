using Strategy;

public class Parrot : IHelp
{
  public string ToHelp(Help call)
  {
    return "I am parrot and I help you to flying!";
  }
}
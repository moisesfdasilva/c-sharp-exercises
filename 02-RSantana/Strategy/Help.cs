namespace Strategy
{
  public class Help
  {
    private IHelp _IHelp;

    public Help(IHelp help)
    {
      _IHelp = help;
    }

    public string ToHelp()
    {
      return _IHelp.ToHelp(this);
    }
  }
}
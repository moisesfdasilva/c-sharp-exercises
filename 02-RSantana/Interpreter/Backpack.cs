public class Backpack : IMessage
{
  private readonly ITool mainTool;
  private readonly ITool secondaryTool;
  private readonly IWeapon weapon;
  public Backpack(ITool mainTool, ITool secondaryTool, IWeapon weapon)
  {
    this.mainTool = mainTool;
    this.secondaryTool = secondaryTool;
    this.weapon = weapon;
  }
  public void Interpreter(Context context)
  {
    context.Content += "Open backpack... \n";

    weapon.Interpreter(context);
    context.Content += "- first tool";
    mainTool.Interpreter(context);
    context.Content += "- second tool";
    secondaryTool.Interpreter(context);

    context.Content += "\n... Closing backpack";
    Console.WriteLine(context.Content);
  }
}

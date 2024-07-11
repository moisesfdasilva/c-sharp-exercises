public class CharacterB : State
{
  public override void Action(Context context)
  {
    context.State = new CharacterA();
  }
}
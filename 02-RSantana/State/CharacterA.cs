public class CharacterA : State
{
  public override void Action(Context context)
  {
    context.State = new CharacterB();
  }
}
public class Player : Entity
{
    public Player() : base()
    {
        pos = new Vector2(100, 100);
        hitBox = new Hitbox(new Vector2(0, 0), new Vector2(50, 50), true, "");
    }

    public void EnterRoom(string room)
    {

    }
}

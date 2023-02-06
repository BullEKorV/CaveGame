public class Player : Entity
{
    State state = State.None;
    public Player() : base()
    {
        pos = new Vector2(100, 100);
        hitBox = new Hitbox(new Vector2(0, 0), new Vector2(50, 50), true, "");
    }
    public override void Update()
    {
        switch (state)
        {
            case State.None:
                Move();
                break;
            case State.Inventory:
                break;
            default:
                break;
        }
    }
    private void Move()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {

        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {

        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {

        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {

        }

    }
    public void EnterRoom(string room)
    {

    }
    enum State
    {
        None,
        Inventory
    }
}

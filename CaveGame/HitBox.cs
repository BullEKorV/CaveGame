public class Hitbox
{
    public Vector2 pos;
    public Vector2 size;
    public bool isSolid;
    public Action action;
    public Hitbox(Vector2 pos, Vector2 size, bool isSolid, string action)
    {
        this.pos = pos;
        this.size = size;
        this.isSolid = isSolid;
        this.action = StringToAction(action);
    }
    private Action StringToAction(string stringAction)
    {
        switch (stringAction)
        {
            case "EnterRoom":
                return () => EnterRoom(stringAction.Remove(0, 9));

            default:
                return Empty;
        }
    }
    public static void EnterRoom(string room)
    {
        new Player().EnterRoom(room);
    }
    public static void Empty()
    {

    }
}

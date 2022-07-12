public class Room
{
    public string name;
    public List<GameObject> gameObjects = new List<GameObject>();
    public Room()
    {
        List<GameObject> objects = new List<GameObject>();

        objects.Add(new Dumb(new Vector2(100, 100)));
    }
}

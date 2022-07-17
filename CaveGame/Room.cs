public class Room
{
    public string name { get; set; }
    public List<GameObjectJSON> gameObjectsJSON { get; set; }
    public List<GameObject> gameObjects;
    public Room()
    {

    }
}
public class GameObjectJSON
{
    public string type { get; set; }
    public int xpos { get; set; }
    public int ypos { get; set; }
}
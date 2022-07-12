public class Game
{
    public Room currentRoom;
    List<Room> rooms = new List<Room>();
    Player player = new Player();
    public void ChangeRoom(string room)
    {
        currentRoom = rooms.Find(x => x.name == room);
    }
    public void Update()
    {

    }
    public void Draw()
    {

    }
}

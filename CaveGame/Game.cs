public class Game
{
    public Room currentRoom;
    Dictionary<string, Room> rooms;
    Player player;
    public Game()
    {
        rooms = LoadAllRooms();
        player = new Player();

        // currentRoom = rooms["1"];
        currentRoom = new Room();
    }
    public void ChangeRoom(string room)
    {
        currentRoom = rooms[room];
    }
    public void Update()
    {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_B))
        {
            currentRoom.gameObjects.Add(new Player());
        }
    }
    public void Draw()
    {

    }
    static Dictionary<string, Room> LoadAllRooms()
    {
        Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        // load from JSON
        string[] roomsDir = Directory.GetFiles(@"Rooms\");
        foreach (string file in roomsDir)
        {
            string response = File.ReadAllText(@file);

            Room room = JsonSerializer.Deserialize<Room>(response);

            rooms.Add(room.name, room);

        }

        return rooms;
    }
}
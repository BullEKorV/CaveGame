global using System.Numerics;
global using Raylib_cs;
global using System.Text.Json;
global using System.IO;

Raylib.InitWindow(1280, 800, "Cavegame");

Game game = new Game();

while (!Raylib.WindowShouldClose())
{
    game.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    game.Draw();

    Raylib.EndDrawing();
}
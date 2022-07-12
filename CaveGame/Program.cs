global using System.Numerics;
global using Raylib_cs;

Raylib.InitWindow(1280, 800, "Cavegame");

Game game = new Game();

// Animation.LoadAnimationsFromDirectories();

while (!Raylib.WindowShouldClose())
{
    game.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    game.Draw();

    Raylib.EndDrawing();
}
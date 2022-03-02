using System;
using System.Numerics;

namespace Idem_01; 

public class Hero {
    public Vector2 position;
    public char sprite;

    public Hero() {
        position = Vector2.Zero;
        sprite = '@';
    }

    public void Action(Tile[,] tileMap) {
        var input = Console.ReadKey();

        var futurePosition = new Vector2(position.X, position.Y);

        futurePosition += input.Key switch {
            ConsoleKey.UpArrow => new Vector2(-1, 0),
            ConsoleKey.DownArrow => new Vector2(1, 0),
            ConsoleKey.RightArrow => new Vector2(0, 1),
            ConsoleKey.LeftArrow => new Vector2(0, -1),
            _ => new Vector2(0, 0)
        };
        FutureTile(tileMap, futurePosition);
    }

    private void FutureTile(Tile[,] tileMap, Vector2 futurePos) {
        var futureTile = tileMap[(int)futurePos.X,(int)futurePos.Y];
        if (futureTile.passable) Move(tileMap, futurePos);
    }

    private void Move(Tile[,] tileMap, Vector2 futurePos) {
        var oldHeroPosition = position;
        position = futurePos;

        tileMap[(int)position.X, (int)position.Y].sprite = sprite;
        tileMap[(int)oldHeroPosition.X, (int)oldHeroPosition.Y].sprite = '.';
    }
}
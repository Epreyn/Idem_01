using System;
using System.Collections.Generic;
using System.Numerics;

namespace Idem_01 {
    public class Tile {
        private Vector2 position;
        public char sprite;
        private bool passable;

        public Tile(Vector2 position, int rowCount, int columnCount) {
            this.position = position;
            sprite = position.X == 0
                     || position.Y == 0
                     || position.X == rowCount - 1
                     || position.Y == columnCount - 1
                ? 'X' : '.';
            passable = sprite == '.';
        }

        public void DrawTile() {
            Console.ForegroundColor = sprite switch {
                '@' => ConsoleColor.Red,
                'X' => ConsoleColor.DarkBlue,
                '.' => ConsoleColor.DarkGray,
                _ => ConsoleColor.DarkGray
            };
            Console.Write(sprite);
        }

        public void AttributeHero() {
            sprite = '@';
        }
    }
}
using System;
using System.Numerics;

namespace Idem_01 {
    public class Map {
        private int rowCount;
        private int columnCount;
        private Tile[,] tileMap;

        public Map(Vector2 size) {
            rowCount = (int)size.X;
            columnCount = (int)size.Y;

            tileMap = new Tile[rowCount,columnCount];

            for (var r = 0; r < rowCount; r++) {
                for (var c = 0; c < columnCount; c++) {
                    tileMap[r, c] = 
                        new Tile(new Vector2(r,c), 
                            rowCount, columnCount);
                    tileMap[r, c].DrawTile();
                }
                Console.WriteLine();
            }
        }
    }
}
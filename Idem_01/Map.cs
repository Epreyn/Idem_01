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
             
                }
            }
        }

        public void PlaceHero(Hero hero, Vector2 mapSize) {
            var random = new Random();
            var isPlaced = false;

            while (!isPlaced) {
                var theoricPos = new Vector2(
                    random.Next(0, (int)mapSize.X),
                    random.Next(0, (int)mapSize.Y)
                );

                if (tileMap[(int)theoricPos.X, (int)theoricPos.Y].sprite == '.') {
                    hero.position = theoricPos;
                    tileMap[(int)theoricPos.X, (int)theoricPos.Y].sprite = hero.sprite;
                    isPlaced = true;
                }
            }

            
  
        }


        public void DisplayMap() {
            for (var r = 0; r < rowCount; r++) {
                for (var c = 0; c < columnCount; c++) {
                    tileMap[r, c].DrawTile();
                }
                Console.WriteLine();
            }
        }
    }
}
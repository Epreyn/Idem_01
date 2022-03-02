using System;
using System.Numerics;

namespace Idem_01 {
    class Program {
        static void Main(string[] args) {
            var rowRange = new Vector2(5, 20);
            var columnRange = new Vector2(10, 100);
            
            var random = new Random();
            
            var size = new Vector2(
                random.Next((int)rowRange.X, (int)rowRange.Y),
                random.Next((int)columnRange.X, (int)columnRange.Y));
            
            var map = new Map(size);
            
            var hero = new Hero();
            map.PlaceHero(hero, size);

            while (true) {
                map.DisplayMap();
                hero.Action(map.tileMap);
                
                Console.Clear();
            }
            
        }
    }
}
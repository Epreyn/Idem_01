using System.Numerics;

namespace Idem_01; 

public class Hero {
    public Vector2 position;
    public char sprite;

    public Hero(Vector2 p) {
        position = p;
        sprite = '@';
    }
}
using UnityEngine;
using UnityEngine.Tilemaps;

public class DesertMapFactory : BaseMapFactory
{
    public DesertMapFactory(
        Tilemap ground,
        GameObject unbreakableWall,
        GameObject breakableWall)
        : base(ground,unbreakableWall, breakableWall)
    {
    }
}
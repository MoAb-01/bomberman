using UnityEngine;
using UnityEngine.Tilemaps;

public class ForestMapFactory : BaseMapFactory
{
    public ForestMapFactory(
        Tilemap ground, // Added this to match Base
        GameObject unbreakableWall,
        GameObject breakableWall)
        : base(ground, unbreakableWall, breakableWall)
    {
    }
}
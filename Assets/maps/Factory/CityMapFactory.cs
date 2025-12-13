using UnityEngine;
using UnityEngine.Tilemaps;

public class CityMapFactory : BaseMapFactory
{
    public CityMapFactory(
        Tilemap ground,
        GameObject cityUnbreakable, // e.g., Concrete Block
        GameObject cityBreakable)   // e.g., Wooden Crate
        : base(ground, cityUnbreakable, cityBreakable)
    {
    }
}
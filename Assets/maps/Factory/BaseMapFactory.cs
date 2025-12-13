using UnityEngine;
using UnityEngine.Tilemaps;

public abstract class BaseMapFactory : IMapFactory
{
    protected Tilemap ground; // Used for position calculation only
    protected GameObject unbreakableWall;
    protected GameObject breakableWall;

    protected BaseMapFactory(
        Tilemap ground,
        GameObject unbreakableWall,
        GameObject breakableWall)
    {
        this.ground = ground;
        this.unbreakableWall = unbreakableWall;
        this.breakableWall = breakableWall;
    }

    public virtual void CreateMap()
    {
        int[,] map = MapLayout.Generate(13, 11);

        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                // We only care about walls (1 or 2)
                if (map[x, y] == 1 || map[x, y] == 2)
                {
                    Vector3Int cell = new Vector3Int(x, y, 0);

                    // Center the prefab on the tile
                    Vector3 pos = ground.CellToWorld(cell) + new Vector3(0.5f, 0.5f, 0);

                    if (map[x, y] == 1)
                    {
                        Object.Instantiate(unbreakableWall, pos, Quaternion.identity);
                    }
                    else if (map[x, y] == 2)
                    {
                        Object.Instantiate(breakableWall, pos, Quaternion.identity);
                    }
                }
            }
        }
    }
}
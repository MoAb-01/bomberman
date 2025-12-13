using UnityEngine;

public static class MapLayout
{
    // 0 = Free
    // 1 = Unbreakable
    // 2 = Breakable

    public static int[,] Generate(int width, int height)
    {
        int[,] map = new int[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // 1. Borders
                if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                {
                    map[x, y] = 1;
                }
                // 2. Pillars (Every alternate cell)
                else if (x % 2 == 0 && y % 2 == 0)
                {
                    map[x, y] = 1;
                }
                // 3. Breakable Walls
                else
                {
                    // Safe Zone (Top-Left)
                    if ((x == 1 && y == 1) || (x == 2 && y == 1) || (x == 1 && y == 2))
                    {
                        map[x, y] = 0;
                    }
                    // Random Chance
                    else if (Random.value < 0.7f)
                    {
                        map[x, y] = 2;
                    }
                }
            }
        }
        return map;
    }
}
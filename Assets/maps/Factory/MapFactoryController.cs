using UnityEngine;
using UnityEngine.Tilemaps;

public class MapFactoryController : MonoBehaviour
{
    [Header("Settings")]
    public MapTheme theme;
    public Tilemap groundTilemap;

    [Header("City Assets")]
    public GameObject cityUnbreakable;
    public GameObject cityBreakable;

    [Header("Desert Assets")]
    public GameObject desertUnbreakable; // New slot for Desert hard wall
    public GameObject desertBreakable;   // New slot for Desert soft wall

    [Header("Forest Assets")]
    public GameObject forestUnbreakable; // New slot for Forest hard wall
    public GameObject forestBreakable;   // New slot for Forest soft wall

    void Start()
    {
        IMapFactory factory = null;

        // Use a switch statement to check which theme is selected
        switch (theme)
        {
            case MapTheme.City:
                factory = new CityMapFactory(
                    groundTilemap,
                    cityUnbreakable,
                    cityBreakable);
                break;

            case MapTheme.Desert:
                factory = new DesertMapFactory(
                    groundTilemap,
                    desertUnbreakable,
                    desertBreakable);
                break;

            case MapTheme.Forest:
                factory = new ForestMapFactory(
                    groundTilemap,
                    forestUnbreakable,
                    forestBreakable);
                break;
        }

        // Safety check: make sure factory was actually created
        if (factory != null)
        {
            factory.CreateMap();
        }
        else
        {
            Debug.LogError("Factory is null! Check if you selected a valid Theme.");
        }
    }
}
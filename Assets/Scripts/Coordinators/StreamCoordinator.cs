using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class StreamCoordinator : MonoBehaviour
{

    List<Vector2> streamLocations = new List<Vector2>();

    // Start is called before the first frame update
    void Start()
    {
        Tilemap tilemap = GetComponent<Tilemap>();

        BoundsInt bounds = tilemap.cellBounds;
        TileBase[] allTiles = tilemap.GetTilesBlock(bounds);
        

        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                TileBase tile = allTiles[x + y * bounds.size.x];
                if (tile != null)
                {
                    streamLocations.Add(new Vector2(x, y));
                }
            }
        }
    }

    List<Vector2> getStreamLocations()
    {
        return streamLocations;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

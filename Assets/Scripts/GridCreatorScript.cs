using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject tilePrefab; // Here, we instantiate the tile prefab
    public int width = 10;
    public int height = 10;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(x, 0, z), Quaternion.identity);
                tile.name = $"Tile_{x}_{z}";
                tile.transform.parent = transform;
                TileData tileInfo = tile.GetComponent<TileData>();
                if (tileInfo != null)
                {
                    tileInfo.SetData(x, z); // Using this function, which is defined in the TileData script, we assign the location information to each tile
                }
            }
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class TilePositionInfo : MonoBehaviour
{
    public Text tileposition; // Reference to UI Text
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            TileData tileInfo = hit.collider.GetComponent<TileData>();
            if (tileInfo != null)
            {
                tileposition.text = $"Tile Position: X={tileInfo.gridX}, Z={tileInfo.gridZ}";
            }
        }
        else
        {
            tileposition.text = "";
        }
    }
}

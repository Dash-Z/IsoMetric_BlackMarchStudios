using UnityEngine;
using UnityEngine.UI;

public class TilePositionInfo : MonoBehaviour
{
    public Text tilepos; // Reference to UI Text
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            TileData tileInfo = hit.collider.GetComponent<TileData>();
            if (tileInfo != null)
            {
                tilepos.text = $"Tile Position: X={tileInfo.Xlocation}, Z={tileInfo.Zlocation}";
            }
        }
        else
        {
            tilepos.text = "";
        }
    }
}

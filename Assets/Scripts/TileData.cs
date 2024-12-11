using UnityEngine;
public class TileData : MonoBehaviour
{
    // We store the location information of each cube in this class
    public int gridX;
    public int gridZ;
    public void SetData(int x,int z)
    {
        gridX = x;
        gridZ = z;
    }
}
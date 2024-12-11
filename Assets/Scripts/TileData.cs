using UnityEngine;
public class TileData : MonoBehaviour
{
    // We store the location information of each cube in this class
    public int Xlocation;
    public int Zlocation;
    public void SetData(int x,int z)
    {
        Xlocation = x;
        Zlocation = z;
    }
}
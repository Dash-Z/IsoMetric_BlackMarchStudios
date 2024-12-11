using UnityEngine;

[CreateAssetMenu(fileName = "ObstacleData", menuName = "Grid/Obstacle Data")]
public class ObstacleData : ScriptableObject
{
    public bool[] obstacles = new bool[100]; //10x10 grid flattened into a 1D array
}

using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    public ObstacleData obsdata;
    public GameObject obstacle;
    private void Start()
    {
        GenerateObstacles();
    }
    void GenerateObstacles()
    {
        // Ensuring that a prefab is assigned properly
        if (obstacle == null)
        {
            Debug.LogError("Prefab is not assigned");
            return;
        }

        for (int y = 0; y < 10; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                int index = y * 10 + x; // We do this because we converted the 10x10 grid to a 100 size 1D Array
                if (obsdata.obstacles[index]) // Detecting if the tile has an obstacle and spawn a sphere slightly above it
                {
                    Vector3 position = new Vector3(x, 0.5f, y);
                    Instantiate(obstacle, position, Quaternion.identity);
                }
            }
        }
    }

    public void RefreshObstacles()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject); // Clear existing obstacles
        }
        GenerateObstacles();
    }
}

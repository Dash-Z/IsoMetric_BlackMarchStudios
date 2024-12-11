using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ObstacleData))]
public class ObsCreator : Editor
{
    public override void OnInspectorGUI()
    {
        ObstacleData data = (ObstacleData)target;
        GUILayout.Label("Obstacle Creation Tool", EditorStyles.boldLabel);

        // Displaying the buttons in the 10x10 grid style
        for (int y = 0; y < 10; y++)
        {
            GUILayout.BeginHorizontal();
            for (int x = 0; x < 10; x++)
            {
                int index = y * 10 + x;
                data.obstacles[index] = GUILayout.Toggle(data.obstacles[index], "", GUILayout.Width(20), GUILayout.Height(20));
            }
            GUILayout.EndHorizontal();
        }

        // Saving changes
        if (GUI.changed)
        {
            EditorUtility.SetDirty(data);
        }
    }
}

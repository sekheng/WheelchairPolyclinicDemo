using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[CustomEditor(typeof(lineup))]
public class lineupEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        lineup cameraController = (lineup)target;

        GUILayout.Space(10);

        if (GUILayout.Button("Lineup"))
        {
            cameraController.StartLineUp();
            EditorSceneManager.SaveOpenScenes();
        }
    }
}

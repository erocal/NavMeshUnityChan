using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class CameraEditor : EditorWindow
{
    public Camera uiCamera;

    [MenuItem("Tools/Camera Editor")]
    public static void Open()
    {
        GetWindow<CameraEditor>();
    }

    private void OnGUI()
    {
        SerializedObject obj = new SerializedObject(this);

        EditorGUILayout.PropertyField(obj.FindProperty("uiCamera"));

        if (uiCamera == null)
        {
            EditorGUILayout.HelpBox("UI相機必須被選取，請拖曳UI相機", MessageType.Warning);
        }
        else
        {
            EditorGUILayout.BeginVertical("box");
            DrawButtons();
            EditorGUILayout.EndVertical();
        }

        obj.ApplyModifiedProperties();
    }

    void DrawButtons()
    {
        if (GUILayout.Button("加入UI相機至所有相機"))
        {
            AddUICamera();
        }
    }

    void AddUICamera()
    {

        Scene scene = SceneManager.GetActiveScene();

        GameObject[] rootObjects = scene.GetRootGameObjects();

        foreach (GameObject obj in rootObjects)
        {
            Camera[] cameras = obj.GetComponentsInChildren<Camera>(true);
            foreach (Camera cam in cameras)
            {
                if (cam != uiCamera)
                {
                    List<Camera> cameraStack = cam.GetUniversalAdditionalCameraData().cameraStack;
                    if (!cameraStack.Contains(uiCamera)) cameraStack.Add(uiCamera);
                }
            }
        }

        Log.Info("UI相機加入完成");

    }
}

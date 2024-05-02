using System.IO;
using UnityEditor;
using UnityEngine;

public class CreateFolderTool : EditorWindow
{

    [MenuItem("Tools/Create Folder/All")]
    static void CreateAllFolder()
    {

        CreateEditorFolder();
        CreateMaterialsFolder();
        CreateMusicFolder();
        CreatePrefabsFolder();
        CreateScenesFolder();
        CreateScriptsFolder();
        CreateShaderFolder();
        CreateThirdPartyFolder();

    }

    [MenuItem("Tools/Create Folder/Editor")]
    static void CreateEditorFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Editor");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Editor��󧨤w�ЫءA���| : " + folderPath);
        }
        else Debug.LogError("Editor��󧨤w�s�b�A���| : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Materials")]
    static void CreateMaterialsFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Materials");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Materials��󧨤w�ЫءA���| : " + folderPath);
        }
        else Debug.LogError("Materials��󧨤w�s�b�A���| : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Music")]
    static void CreateMusicFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Music");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Music��󧨤w�ЫءA���| : " + folderPath);
        }
        else Debug.LogError("Music��󧨤w�s�b�A���| : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Prefabs")]
    static void CreatePrefabsFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Prefabs");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Prefabs��󧨤w�ЫءA���| : " + folderPath);
        }
        else Debug.LogError("Prefabs��󧨤w�s�b�A���| : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Scenes")]
    static void CreateScenesFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Scenes");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Scenes��󧨤w�ЫءA���| : " + folderPath);
        }
        else Debug.LogError("Scenes��󧨤w�s�b�A���| : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Scripts")]
    static void CreateScriptsFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Scripts");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Scripts��󧨤w�ЫءA���| : " + folderPath);
        }
        else Debug.LogError("Scripts��󧨤w�s�b�A���| : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Shader")]
    static void CreateShaderFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Shader");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Shader��󧨤w�ЫءA���| : " + folderPath);
        }
        else Debug.LogError("Shader��󧨤w�s�b�A���| : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/ThirdParty")]
    static void CreateThirdPartyFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "ThirdParty");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("ThirdParty��󧨤w�ЫءA���| : " + folderPath);
        }
        else Debug.LogError("ThirdParty��󧨤w�s�b�A���| : " + folderPath);
    }

}
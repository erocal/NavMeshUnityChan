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
            Debug.Log("Editor文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("Editor文件夾已存在，路徑 : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Image")]
    static void CreateImageFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Image");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Image文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("Image文件夾已存在，路徑 : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Materials")]
    static void CreateMaterialsFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Materials");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Materials文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("Materials文件夾已存在，路徑 : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Music")]
    static void CreateMusicFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Music");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Music文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("Music文件夾已存在，路徑 : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Prefabs")]
    static void CreatePrefabsFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Prefabs");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Prefabs文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("Prefabs文件夾已存在，路徑 : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Scenes")]
    static void CreateScenesFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Scenes");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Scenes文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("Scenes文件夾已存在，路徑 : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Scripts")]
    static void CreateScriptsFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Scripts");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Scripts文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("Scripts文件夾已存在，路徑 : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/Shader")]
    static void CreateShaderFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "Shader");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("Shader文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("Shader文件夾已存在，路徑 : " + folderPath);
    }

    [MenuItem("Tools/Create Folder/ThirdParty")]
    static void CreateThirdPartyFolder()
    {
        string folderPath = Path.Combine(Application.dataPath, "ThirdParty");

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("ThirdParty文件夾已創建，路徑 : " + folderPath);
        }
        else Debug.LogError("ThirdParty文件夾已存在，路徑 : " + folderPath);
    }

}
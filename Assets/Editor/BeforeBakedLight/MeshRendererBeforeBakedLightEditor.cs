using UnityEditor;
using UnityEngine;

public class MeshRendererBeforeBakedLightEditor : MonoBehaviour
{
    [MenuItem("Tools/烘培光前/MeshRenderer/開啟LightMap")]
    static void MeshRendererOpenLightMap()
    {

        MeshRenderer[] renderers = FindObjectsOfType<MeshRenderer>();

        foreach (MeshRenderer renderer in renderers)
        {
            renderer.receiveGI = ReceiveGI.Lightmaps;
        }

        Log.Info("場景全部物件MeshRenderer更改為接收光照貼圖成功!");

    }
}

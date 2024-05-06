using UnityEditor;
using UnityEngine;

public class MeshRendererBeforeBakedLightEditor : MonoBehaviour
{
    [MenuItem("Tools/�M�����e/MeshRenderer/�}��LightMap")]
    static void MeshRendererOpenLightMap()
    {

        MeshRenderer[] renderers = FindObjectsOfType<MeshRenderer>();

        foreach (MeshRenderer renderer in renderers)
        {
            renderer.receiveGI = ReceiveGI.Lightmaps;
        }

        Log.Info("������������MeshRenderer��אּ�������ӶK�Ϧ��\!");

    }
}

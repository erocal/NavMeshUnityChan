using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    #region -- 資源參考區 --

    [SerializeField, Tooltip("俯視相機")] private Camera topViewCamera;
    [SerializeField, Tooltip("從上方俯視位置")] private Transform topView;
    [Header("監視器")]
    [SerializeField, Tooltip("監視器相機列表")] private List<Camera> securityCameraList;

    #endregion

    #region -- 變數參考區 --

    private int curCameraId = 0;

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
    {

        InitTopViewPosition();

    }

    private void Update()
    {

    }

    #endregion

    #region -- 方法參考區 --

    /// <summary>
    /// 初始化主相機從上方俯視的位置
    /// </summary>
    private void InitTopViewPosition()
    {

        if (topView != null && topViewCamera != null)
        {
            topViewCamera.enabled = true;
            topViewCamera.transform.SetPositionAndRotation(topView.position, topView.rotation);
        }

    }

    #region -- Btn --

    public void OnTopView()
    {

        topViewCamera.enabled = true;
        topViewCamera.depth = 0;

        foreach (Camera camera in securityCameraList)
        {
            if (camera.enabled)
            {
                camera.enabled = false;
                camera.depth = -1;
            }
        }

    }

    public void OnSwitchCamera()
    {

        topViewCamera.enabled = false;
        topViewCamera.depth = -1;

        if(securityCameraList.Count == curCameraId) curCameraId = 0;

        securityCameraList[curCameraId].depth = 0;
        securityCameraList[curCameraId].enabled = true;

        curCameraId++;

    }

    #endregion

    #endregion

}

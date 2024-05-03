using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region -- 資源參考區 --

    [SerializeField, Tooltip("從上方俯視")] private Transform topView;

    #endregion

    #region -- 變數參考區 --

    Camera mainCamera;

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
    {

        mainCamera = Camera.main;
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

        if (topView != null && mainCamera != null)
        {
            mainCamera.transform.position = topView.position;
            mainCamera.transform.rotation = topView.rotation;
        }

    }

    #region -- Btn --

    public void OnTopView()
    {
        mainCamera.depth = 0;
    }

    #endregion

    #endregion
}

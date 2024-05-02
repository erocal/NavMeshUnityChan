using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region -- 資源參考區 --

    [SerializeField, Tooltip("從上方俯視")] private Transform topView;

    #endregion

    #region -- 變數參考區 --

    Camera camera;

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
    {

        camera = Camera.main;
        InitTopView();

    }

    private void Update()
    {

    }

    #endregion

    #region -- 方法參考區 --

    /// <summary>
    /// 初始化相機從上方俯視
    /// </summary>
    private void InitTopView()
    {

        if (topView != null && camera != null)
        {
            camera.transform.position = topView.position;
            camera.transform.rotation = topView.rotation;
        }

    }

    #endregion
}

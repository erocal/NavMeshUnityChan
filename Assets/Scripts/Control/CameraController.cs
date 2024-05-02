using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region -- �귽�ѦҰ� --

    [SerializeField, Tooltip("�q�W�����")] private Transform topView;

    #endregion

    #region -- �ܼưѦҰ� --

    Camera camera;

    #endregion

    #region -- ��l��/�B�@ --

    private void Awake()
    {

        camera = Camera.main;
        InitTopView();

    }

    private void Update()
    {

    }

    #endregion

    #region -- ��k�ѦҰ� --

    /// <summary>
    /// ��l�Ƭ۾��q�W�����
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

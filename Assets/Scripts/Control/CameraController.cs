using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region -- �귽�ѦҰ� --

    [SerializeField, Tooltip("�q�W�����")] private Transform topView;

    #endregion

    #region -- �ܼưѦҰ� --

    Camera mainCamera;

    #endregion

    #region -- ��l��/�B�@ --

    private void Awake()
    {

        mainCamera = Camera.main;
        InitTopViewPosition();

    }

    private void Update()
    {

    }

    #endregion

    #region -- ��k�ѦҰ� --

    /// <summary>
    /// ��l�ƥD�۾��q�W���������m
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

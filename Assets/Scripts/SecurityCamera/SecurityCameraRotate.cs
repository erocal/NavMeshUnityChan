using DG.Tweening;
using UnityEngine;

public class SecurityCameraRotate : MonoBehaviour
{

    #region -- 資源參考區 --

    [SerializeField, Tooltip("起始角度")] private Quaternion fromRotation = Quaternion.Euler(0f, 45f, 0f);
    [SerializeField, Tooltip("目標角度")] private Quaternion toRotation = Quaternion.Euler(0f, -45f, 0f);
    [SerializeField, Tooltip("移動速度"), Range(1, 10)] private int rotateSpeed = 2;

    #endregion

    #region -- 變數參考區 --

    private bool isRotate;

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
    {

        isRotate = true;
        RotateToFromRotation();

    }

    private void Update()
    {

        RotateBackAndForth();

    }

    #endregion

    #region -- 方法參考區 --

    /// <summary>
    /// 旋轉至起始角度
    /// </summary>
    private void RotateToFromRotation()
    {
        transform.DOLocalRotate(fromRotation.eulerAngles, 10 / rotateSpeed).SetEase(Ease.Linear);
    }

    /// <summary>
    /// 無限來回旋轉
    /// </summary>
    private void RotateBackAndForth()
    {

        if (!isRotate) return;

        if(transform.localRotation.eulerAngles == fromRotation.eulerAngles) transform.DOLocalRotate(toRotation.eulerAngles, 10 / rotateSpeed).SetEase(Ease.Linear);

        if (transform.localRotation.eulerAngles == toRotation.eulerAngles) transform.DOLocalRotate(fromRotation.eulerAngles, 10 / rotateSpeed).SetEase(Ease.Linear);

    }

    #endregion

}

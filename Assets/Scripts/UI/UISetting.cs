using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UISetting : MonoBehaviour
{

	#region -- 資源參考區 --

	[Header("RectTransform")]
	[SerializeField] private RectTransform RectTransform_BtnSetting;
    [Header("CanvasGroup")]
    [SerializeField] private CanvasGroup CanvasGroup_Setting;

    #endregion

    #region -- 變數參考區 --

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
	{
		
	}

	private void Update()
	{
		
	}

    #endregion

    #region -- 方法參考區 --

	/// <summary>
	/// 旋轉設定圖示
	/// </summary>
    private void RotateSettingIcon()
	{

        Button BtnSetting = RectTransform_BtnSetting.GetComponent<Button>();

        if (RectTransform_BtnSetting.rotation == new Quaternion(0, 0, 0, 1))
		{

            BtnSetting.interactable = false;
			RectTransform_BtnSetting.DORotate(new Vector3(0, 0, 90f), 0.5f).OnComplete(() =>
			{
                BtnSetting.interactable = true;
            });

        }
		else
		{

            BtnSetting.interactable = false;
            RectTransform_BtnSetting.DORotate(Vector3.zero, 0.5f).OnComplete(() =>
            {
                BtnSetting.interactable = true;
            });

        }

    }

    #region -- btn --

    public void OnSetting()
	{

		RotateSettingIcon();
        CanvasGroup_Setting.SetEnable(true);

    }

    public void OnClose()
    {

        RotateSettingIcon();
        CanvasGroup_Setting.SetEnable(false);

    }

    #endregion

    #endregion

}

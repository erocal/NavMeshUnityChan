using UnityEngine;

public class MusicSlider : MonoBehaviour
{

    #region -- 資源參考區 --

    [SerializeField] private Material musicSlider;

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

    #region -- Slider --

    public void OnSliderValueChanged(float value)
    {
        musicSlider.SetFloat("_Slider", value);
    }

    #endregion

    #endregion

}

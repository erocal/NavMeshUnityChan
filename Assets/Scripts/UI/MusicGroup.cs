using UnityEngine;
using UnityEngine.UI;

public class MusicGroup : MonoBehaviour
{

    #region -- 資源參考區 --

    [Header("Material")]
    [SerializeField] private Material musicSlider;
    [Header("Image")]
    [SerializeField] private Image Image_Music;
    [SerializeField] private Image Image_Handle;

    #endregion

    #region -- 變數參考區 --

    #region -- 常數 --

    private const float GOLDEN_COLOR_R = 0.8962264f;
    private const float GOLDEN_COLOR_G = 0.7648386f;
    private const float GOLDEN_COLOR_B = 0.1986917f;

    #endregion

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
	{
        musicSlider.SetFloat("_Slider", 0);
    }

	private void Update()
	{
		
	}

    #endregion

    #region -- 方法參考區 --

    #region -- Slider --

    public void OnSliderValueChanged(float value)
    {
        Color goldenColor = new Color(GOLDEN_COLOR_R, GOLDEN_COLOR_G, GOLDEN_COLOR_B);

        musicSlider.SetFloat("_Slider", value);
        Image_Music.color = value != 0 ? goldenColor : Color.black;
        Image_Handle.color = value != 0 ? goldenColor : Color.black;

    }

    #endregion

    #endregion

}

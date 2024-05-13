using System.Text;
using TMPro;
using UnityEngine;

public class UICurrentUnityChan : MonoBehaviour
{

	#region -- 資源參考區 --

	[SerializeField] private TextMeshProUGUI Text_CurrentUnityChan;

    #endregion

    #region -- 變數參考區 --

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
	{
		
	}

	private void Update()
	{

		CurrentUnityChan();

    }

    #endregion

    #region -- 方法參考區 --

    /// <summary>
    /// 更新場上現有UnityChan!數量
    /// </summary>
    private void CurrentUnityChan()
    {

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("目前場上有 : ");
        stringBuilder.Append(ObjectPoolHelper.GetCurActiveUnityChanPool().Count);
        stringBuilder.Append(" UnityChan!");

        Text_CurrentUnityChan.text = stringBuilder.ToString();

    }

    #endregion

}

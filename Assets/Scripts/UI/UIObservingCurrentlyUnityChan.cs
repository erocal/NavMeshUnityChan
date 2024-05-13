using System.Text;
using TMPro;
using UnityEngine;

public class UIObservingCurrentlyUnityChan : MonoBehaviour
{

	#region -- 資源參考區 --

	[SerializeField] private CameraController cameraController;
	[SerializeField] private TextMeshProUGUI Text_ObservingCurrentlyUnityChan;

    #endregion

    #region -- 變數參考區 --

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
	{
		
	}

	private void Update()
	{

        ObservingCurrentlyUnityChan();

    }

    #endregion

    #region -- 方法參考區 --

    /// <summary>
    /// 更新Text_ObservingCurrentlyUnityChan
    /// </summary>
    private void ObservingCurrentlyUnityChan()
    {

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append("目前觀測到 : ");
        stringBuilder.Append(ObservingCurrentlyUnityChanAmount());
        stringBuilder.Append(" UnityChan!");

        Text_ObservingCurrentlyUnityChan.text = stringBuilder.ToString();

    }

    /// <summary>
    /// 觀測到的UnityChan!數量
    /// </summary>
    /// <returns></returns>
	private int ObservingCurrentlyUnityChanAmount()
	{

		int curObservingUnityChan = 0;

        foreach (GameObject unityChan in ObjectPoolHelper.GetCurActiveUnityChanPool())
		{

			if (IsObjectVisible(unityChan.transform.position)) curObservingUnityChan++;

        }

		return curObservingUnityChan;

    }

	/// <summary>
	/// 是否在目前相機視線內
	/// </summary>
    private bool IsObjectVisible(Vector3 position)
    {
		Camera curCamera = cameraController.curCameraId == -1 ? cameraController.topViewCamera : cameraController.securityCameraList[cameraController.curCameraId];

        // 將物體的位置轉換到相機的局部空間
        Vector3 viewportPoint = curCamera.WorldToViewportPoint(position);

        // 如果物體在相機的視錐體內且在相機的前方，返回true
        return (viewportPoint.x >= 0 && viewportPoint.x <= 1 &&
                viewportPoint.y >= 0 && viewportPoint.y <= 1 &&
                viewportPoint.z > 0);
    }

    #endregion

}

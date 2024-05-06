using UnityEngine;

public class ScreenRotate : MonoBehaviour
{

	#region -- 資源參考區 --

	#endregion
	
	#region -- 變數參考區 --

	#endregion
	
    #region -- 初始化/運作 --

	private void Awake()
	{
		
		Screen.orientation = ScreenOrientation.AutoRotation;
		Screen.autorotateToLandscapeLeft = true;
		Screen.autorotateToLandscapeRight = true;
		Screen.autorotateToPortrait = false;
		Screen.autorotateToPortraitUpsideDown = false;

	}

	private void Update()
	{
		
	}

	#endregion
	
	#region -- 方法參考區 --

	#endregion
	
}

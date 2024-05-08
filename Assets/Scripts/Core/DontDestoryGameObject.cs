using UnityEngine;

public class DontDestoryGameObject : MonoBehaviour
{

	#region -- 資源參考區 --

	#endregion
	
	#region -- 變數參考區 --

	#endregion
	
    #region -- 初始化/運作 --

	private void Awake()
	{
		GameObject.DontDestroyOnLoad(this.gameObject);
	}

	#endregion
	
	#region -- 方法參考區 --

	#endregion
	
}

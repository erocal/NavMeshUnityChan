using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolHelper : UnityChanObjectPool
{

	#region -- 資源參考區 --

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
	/// 目前活動的UnityChan!物件池
	/// </summary>
	/// <returns></returns>
	public static List<GameObject> GetCurActiveUnityChanPool()
	{

		return activeUnityChanPool;

    }

    #endregion

}

using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    #region -- 資源參考區 --

    public List<Waypoint> waypoints;

    #endregion

    #region -- 變數參考區 --

    private static WaypointManager _instance;

    public static WaypointManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<WaypointManager>();
            }

            return _instance;
        }
        private set { }
    }


    #endregion

    #region -- 初始化/運作 --

    // 防止外部實例化該類
    private WaypointManager()
    {
    }

    private void Awake()
    {
        GetInstance();
    }

    private void OnDestroy()
    {
        _instance = null;
    }

    #endregion

    #region -- 方法參考區 --

    #region -- 單例模式 --

    /// <summary>
    /// 獲取唯一實例
    /// </summary>
    private void GetInstance()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject); // 如果已經有一個實例存在，銷毀這個新的實例
            return;
        }
    }

    #endregion

    #endregion
}

using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    #region -- �귽�ѦҰ� --

    public List<Waypoint> waypoints;

    #endregion

    #region -- �ܼưѦҰ� --

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

    #region -- ��l��/�B�@ --

    // ����~����ҤƸ���
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

    #region -- ��k�ѦҰ� --

    #region -- ��ҼҦ� --

    /// <summary>
    /// ����ߤ@���
    /// </summary>
    private void GetInstance()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject); // �p�G�w�g���@�ӹ�Ҧs�b�A�P���o�ӷs�����
            return;
        }
    }

    #endregion

    #endregion
}

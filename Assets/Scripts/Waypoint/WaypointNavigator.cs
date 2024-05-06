using UnityEngine;

public class WaypointNavigator : MonoBehaviour
{

    #region -- 資源參考區 --

    [SerializeField] private UnityChanController unityChanController;
    public Waypoint currentWaypoint;

    #endregion

    #region -- 變數參考區 --

    private Vector3 destination;

    private int direction;

    #endregion

    #region -- 初始化/運作 --

    public void Awake()
    {

        RandomChangeDirection();
        InitWayPoint();
        InitSetDestination();

    }

    private void Update()
    {

        ReachedDestination();

    }

    #endregion

    #region -- 方法參考區 --

    /// <summary>
    /// 隨機改變行進方向
    /// </summary>
    private void RandomChangeDirection()
    {
        direction = Random.Range(0, 2);
    }

    /// <summary>
    /// 改變Waypoint
    /// </summary>
    private void ChangeCurrentWaypoint()
    {
        currentWaypoint = direction == 0 ? ChangeToNextWaypoint() : ChangeToPreviousWaypoint();
    }

    /// <summary>
    /// 改變目前Waypoint為NextWaypoint
    /// </summary>
    private Waypoint ChangeToNextWaypoint()
    {
        if(currentWaypoint.nextWaypoint != null)
            return currentWaypoint.nextWaypoint;
        else return currentWaypoint.previousWaypoint;
    }

    /// <summary>
    /// 改變目前Waypoint為PreviousWaypoint
    /// </summary>
    private Waypoint ChangeToPreviousWaypoint()
    {
        if (currentWaypoint.previousWaypoint != null)
            return currentWaypoint.previousWaypoint;
        else return currentWaypoint.nextWaypoint;
    }

    /// <summary>
    /// 初始化設定WayPoint
    /// </summary>
    private void InitWayPoint()
    {
        var waypoints = WaypointManager.Instance.waypoints;

        currentWaypoint = waypoints[Random.Range(0, waypoints.Count - 1)];
    }

    /// <summary>
    /// 移動至初始目的地
    /// </summary>
    private void InitSetDestination()
    {
        UnityChanSetDestination();
    }

    private void UnityChanSetDestination()
    {
        if (unityChanController != null && currentWaypoint != null)
        {
            destination = currentWaypoint.GetPosition();
            unityChanController.SetDestination(destination);
        }
        else Debug.LogError("unityChanController或currentWaypoint為空");
    }

    /// <summary>
    /// 到達目的地
    /// </summary>
    private void ReachedDestination()
    {
        if (CheckReachedDestination())
        {
            bool shouldBranch = false;
            if (currentWaypoint.branches != null && currentWaypoint.branches.Count > 0)
                shouldBranch = Random.Range(0f, 1f) <= 
                    currentWaypoint.brancheRatio ? true : false;

            if (shouldBranch)
            {
                currentWaypoint = currentWaypoint.branches[
                    Random.Range(0, currentWaypoint.branches.Count - 1)];
            }
            else
            {
                RandomChangeDirection();
                ChangeCurrentWaypoint();
            }
            
            UnityChanSetDestination();

            StartCoroutine(unityChanController.RandomChangeSpeed());

        }
    }

    /// <summary>
    /// 確認抵達目的地
    /// </summary>
    private bool CheckReachedDestination()
    {

        if (currentWaypoint == null) return false;

        // 計算物體與目的地之間的距離
        float distanceToDestination = Vector3.Distance(this.transform.position, currentWaypoint.GetPosition());

        return distanceToDestination <= currentWaypoint.width*2;

    }

    #endregion

}

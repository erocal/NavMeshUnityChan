using UnityEngine;
using UnityEngine.AI;

public class WaypointNavigator : MonoBehaviour
{
    #region -- �귽�ѦҰ� --

    NavMeshAgent navMeshAgent;
    public Waypoint currentWaypoint;

    #endregion

    #region -- �ܼưѦҰ� --

    #endregion

    #region -- ��l��/�B�@ --

    private void Awake()
    {
        if (navMeshAgent != null) navMeshAgent.SetDestination(currentWaypoint.GetPosition());
    }

    private void Update()
    {

        

    }

    #endregion

    #region -- ��k�ѦҰ� --

    #endregion
}

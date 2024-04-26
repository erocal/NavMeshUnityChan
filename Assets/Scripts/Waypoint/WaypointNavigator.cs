using UnityEngine;
using UnityEngine.AI;

public class WaypointNavigator : MonoBehaviour
{
    #region -- 戈方把σ跋 --

    NavMeshAgent navMeshAgent;
    public Waypoint currentWaypoint;

    #endregion

    #region -- 跑计把σ跋 --

    #endregion

    #region -- ﹍て/笲 --

    private void Awake()
    {
        if (navMeshAgent != null) navMeshAgent.SetDestination(currentWaypoint.GetPosition());
    }

    private void Update()
    {

        

    }

    #endregion

    #region -- よ猭把σ跋 --

    #endregion
}

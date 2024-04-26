using UnityEngine;

public class Waypoint : MonoBehaviour
{
    #region -- 戈方把σ跋 --

    public Waypoint previousWaypoint;
    public Waypoint nextWaypoint;

    [Range(0f, 5f)] public float width = 1f;

    #endregion

    #region -- 跑计把σ跋 --

    #endregion

    #region -- ﹍て/笲 --

    private void Awake()
    {

    }

    private void Update()
    {

    }

    #endregion

    #region -- よ猭把σ跋 --

    public Vector3 GetPosition()
    {
        Vector3 minBound = transform.position + transform.right * width / 2f;
        Vector3 maxBound = transform.position - transform.right * width / 2f;

        return Vector3.Lerp(minBound, maxBound, Random.Range(0f, 1f));
    }

    #endregion
}

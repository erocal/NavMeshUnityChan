using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator), typeof(NavMeshAgent))]
public class UnityChanController : MonoBehaviour
{

    public Vector3 destination;
    [SerializeField] private Animator unityChanAnimator;
    [SerializeField] private NavMeshAgent navMeshAgent;

    #region -- �귽�ѦҰ� --

    #endregion

    #region -- �ܼưѦҰ� --

    private bool hasNecessaryComponent = true;

    #endregion

    #region -- ��l��/�B�@ --

    private void Awake()
    {

        if(CheckNecessaryComponent()) hasNecessaryComponent = false;

    }

    private void Update()
    {

        if (!hasNecessaryComponent) return;

        NavMeshAgentSpeedToAnimator();

    }

    #endregion

    #region -- ��k�ѦҰ� --

    /// <summary>
    /// �T�{���n�ե�O�_����m�A����m�^��true
    /// </summary>
    private bool CheckNecessaryComponent()
    {
        if (navMeshAgent == null)
        {
            Debug.LogError("���f��navMeshAgent");
            return true;
        }
        if (unityChanAnimator == null)
        {
            Debug.LogError("���f��Animator");
            return true;
        }

        return false;
    }

    private void NavMeshAgentSpeedToAnimator()
    {
        unityChanAnimator.SetFloat("Speed", navMeshAgent.speed);
    }

    /// <summary>
    /// �]�wNavMeashAgent���ت��a
    /// </summary>
    public void SetDestination(Vector3 value)
    {
        destination = value;
        if (navMeshAgent != null)
            navMeshAgent.SetDestination(destination);
        else Debug.LogError("���f��navMeshAgent");
    }

    /// <summary>
    /// �H���]�wNavMeashAgent���t��
    /// </summary>
    public IEnumerator RandomChangeSpeed()
    {
        int navMeshAgentSpeed = Random.Range(0, 10);
        navMeshAgent.speed = navMeshAgentSpeed;
        navMeshAgent.avoidancePriority = 50;

        if (navMeshAgentSpeed == 0)
        {
            navMeshAgent.avoidancePriority = 1;
            int waitTime = Random.Range(5, 30);
            if (waitTime > 5) unityChanAnimator.SetBool("Rest", true);

            yield return new WaitForSeconds(waitTime);

            if (waitTime > 5) unityChanAnimator.SetBool("Rest", false);
            StartCoroutine(RandomChangeSpeed());
        }
    }

    #endregion
}

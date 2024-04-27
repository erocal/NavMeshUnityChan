using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator), typeof(NavMeshAgent))]
public class UnityChanController : MonoBehaviour
{

    public Vector3 destination;
    [SerializeField] private Animator unityChanAnimator;
    [SerializeField] private NavMeshAgent navMeshAgent;

    #region -- 戈方把σ跋 --

    #endregion

    #region -- 跑计把σ跋 --

    private bool hasNecessaryComponent = true;

    #endregion

    #region -- ﹍て/笲 --

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

    #region -- よ猭把σ跋 --

    /// <summary>
    /// 絋粄ゲ璶舱ン琌ゼ竚ゼ竚肚true
    /// </summary>
    private bool CheckNecessaryComponent()
    {
        if (navMeshAgent == null)
        {
            Debug.LogError("ゼ穎更navMeshAgent");
            return true;
        }
        if (unityChanAnimator == null)
        {
            Debug.LogError("ゼ穎更Animator");
            return true;
        }

        return false;
    }

    private void NavMeshAgentSpeedToAnimator()
    {
        unityChanAnimator.SetFloat("Speed", navMeshAgent.speed);
    }

    /// <summary>
    /// 砞﹚NavMeashAgentヘ
    /// </summary>
    public void SetDestination(Vector3 value)
    {
        destination = value;
        if (navMeshAgent != null)
            navMeshAgent.SetDestination(destination);
        else Debug.LogError("ゼ穎更navMeshAgent");
    }

    /// <summary>
    /// 繦诀砞﹚NavMeashAgent硉
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

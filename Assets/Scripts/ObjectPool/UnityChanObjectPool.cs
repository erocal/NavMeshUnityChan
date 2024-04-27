using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanObjectPool : MonoBehaviour
{
    #region -- 戈方把σ跋 --

    [SerializeField, Tooltip("ン把σ癸禜")] private GameObject unityChan;
    [SerializeField, Tooltip("﹍箇ネΘ计秖")] private int initailSize = 20;

    #endregion

    #region -- 跑计把σ跋 --

    private Queue<GameObject> unityChanObjectPool = new Queue<GameObject>();

    #endregion

    #region -- ﹍て/笲 --

    private void Awake()
    {
        StartCoroutine(InitUnityChan());
    }

    #endregion

    #region -- よ猭把σ跋 --

    IEnumerator InitUnityChan()
    {
        for (int i = 0; i < initailSize; i++)
        {
            GameObject go = Instantiate(unityChan, this.transform);
            unityChanObjectPool.Enqueue(go);

            yield return new WaitForSeconds(1);
        }
    }

    public void ReUse(Vector3 position, Quaternion rotation)
    {
        if (unityChanObjectPool.Count > 0)
        {
            GameObject reuse = unityChanObjectPool.Dequeue();
            reuse.transform.position = position;
            reuse.transform.rotation = rotation;
            reuse.SetActive(true);
        }
        else
        {
            GameObject go = Instantiate(unityChan, this.transform);
            go.transform.position = position;
            go.transform.rotation = rotation;
        }
    }


    public void Recovery(GameObject recovery)
    {
        unityChanObjectPool.Enqueue(recovery);
        recovery.SetActive(false);
    }

    #endregion
}

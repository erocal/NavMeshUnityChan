using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UnityChanObjectPool : MonoBehaviour
{
    #region -- �귽�ѦҰ� --

    [SerializeField, Tooltip("������Ѧҹ�H")] private GameObject unityChan;
    [SerializeField, Tooltip("��l�w�ͦ��ƶq")] private int initailSize = 20;

    #endregion

    #region -- �ܼưѦҰ� --

    #region -- �`�� --

    private Vector3 spawnPoistion = new(-6.64f, 9.75f, 11.017f);

    #endregion

    [Tooltip("���������UnityChan!")]
    private Queue<GameObject> unityChanObjectPool = new Queue<GameObject>();

    [Tooltip("���ʤ���UnityChan!")]
    private Queue<GameObject> activeUnityChanPool = new Queue<GameObject>();

    #endregion

    #region -- ��l��/�B�@ --

    private void Awake()
    {
        StartCoroutine(InitUnityChan());
    }

    #endregion

    #region -- ��k�ѦҰ� --

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
            reuse.GetComponent<WaypointNavigator>().Awake();
            activeUnityChanPool.Enqueue(reuse);
        }
        else
        {
            GameObject go = Instantiate(unityChan, this.transform);
            go.transform.position = position;
            go.transform.rotation = rotation;
            activeUnityChanPool.Enqueue(go);
        }
    }

    public void Recovery(GameObject recovery)
    {
        unityChanObjectPool.Enqueue(recovery);
        recovery.SetActive(false);
    }

    #region -- btn --

    public void OnCreateCharacter()
    {

        ReUse(spawnPoistion, Quaternion.identity);

    }

    public void OnRemoveCharacter()
    {
        if (activeUnityChanPool.Count > 0) Recovery(activeUnityChanPool.Dequeue());
    }

    #endregion

    #endregion
}

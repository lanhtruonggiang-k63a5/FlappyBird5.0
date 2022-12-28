using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePooling : MonoBehaviour
{
    private GameObject[] pool;
    public GameObject prefab;
    public int size;

    public float height;
    int pointer = 0;
    //timer
    [SerializeField] private float remainTime;
    private float countTRemain;
    void Start()
    {
        pool = new GameObject[size];
        for (int i = 0; i < size; i++)
        {

            pool[i] = Instantiate(prefab);
            pool[i].SetActive(false);

        }


    }
    private void Update()
    {
        VisibleTwo();
    }
    private void VisibleTwo()
    {
        // if (countTRemain > remainTime)
        // {    

        //     pool[pointer].SetActive(true);
        //     SetRandomPosition(pool[pointer]);
        //     countTRemain = 0f;
        //     SetPointer(pointer);
        // }
        // countTRemain += Time.deltaTime;
        // pool[pointer].SetActive(false);


        if (countTRemain > remainTime && BirdBehavior.s_isDeath==false)
        {
            pool[pointer].SetActive(true);
            SetRandomPosition(pool[pointer]);
            countTRemain = 0f;
            pointer = (pointer + 1) % size;
        }
        
        countTRemain += Time.deltaTime;
    }
    


    private void SetRandomPosition(GameObject obj)
    {
        obj.transform.position = transform.position + new Vector3(0, GenRandomHeight(), 0);

    }
    private float GenRandomHeight()
    {
        float saveHeight = Random.Range(-height, height);
        return saveHeight;
    }




}

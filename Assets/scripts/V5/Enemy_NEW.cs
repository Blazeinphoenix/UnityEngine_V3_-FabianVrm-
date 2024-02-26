using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Enemy_NEW : MonoBehaviour
{

    static public Queue<GameObject> EnemyQueue = new Queue<GameObject>();

    void Start()
    {

        EnemyQueue.Enqueue(gameObject);
        print($"Momentane Enemys in der Scene: {EnemyQueue.Count}");
    }


    private void ColorChange()
    {
        GameObject nextObj = EnemyQueue.Dequeue();
        nextObj.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        EnemyQueue.Enqueue(nextObj);


    }

    
}

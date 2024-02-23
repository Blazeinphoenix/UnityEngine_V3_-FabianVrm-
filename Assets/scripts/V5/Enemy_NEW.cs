using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Enemy_NEW : MonoBehaviour
{

    static public Queue<GameObject> EnemyQueue = new Queue<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

        EnemyQueue.Enqueue(gameObject);
        print($"Momentane Enemys in der Scene: {EnemyQueue.Count}");
    }

    // Update is called once per frame

    private void ColorChange()
    {
        GameObject nextObj = EnemyQueue.Dequeue();
        nextObj.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        EnemyQueue.Enqueue(nextObj);


    }

    // Update is called once per frame
    
}

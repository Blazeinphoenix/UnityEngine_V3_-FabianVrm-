using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Queue<GameObject> EnemyQueue = new Queue<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void ColorChange()
    {
        GameObject nextObj = EnemyQueue.Dequeue();
        nextObj.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        EnemyQueue.Enqueue(nextObj);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ColorChange();
        }
    }
}

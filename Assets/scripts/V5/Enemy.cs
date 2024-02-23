using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyManager enemyManager;
    // Start is called before the first frame update
    void Start()
    {
        enemyManager = FindObjectOfType<EnemyManager>();

        enemyManager.EnemyQueue.Enqueue(gameObject);
    }

   
   

    // Update is called once per frame
    void Update()
    {
        
    }
}

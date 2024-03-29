 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyToSpawn;
    [SerializeField] private float spawnRange = 5f;
    [SerializeField] private int poolSize = 10;


    private void Start()
    {
        /*Enemy_NEW.EnemyQueue.Enqueue(gameObject);
        for (int i = 0; i < poolSize; i++)
        {
            enemyToSpawn = Instantiate(enemyToSpawn);
            
        }
        */
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject objectToSpawn = Resources.Load<GameObject>("Enemy");
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), Random.Range(-spawnRange, spawnRange));
            Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            ColorChange();
        }
        

    }


    /*public GameObject GetPoolEnemys()
    {
        if(enemyToSpawn)
    }
    */
    private void ColorChange()
    {
        GameObject nextObj = Enemy_NEW.EnemyQueue.Dequeue();
        nextObj.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        Enemy_NEW.EnemyQueue.Enqueue(nextObj);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    private GameObject enemy;
    public int damageAmount;
    private EnemyCon enemyCon;

    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyCon = enemy.GetComponent<EnemyCon>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GiveDamage();
        }
    }

    void GiveDamage()
    {
        enemyCon.TakeDamage(damageAmount);
    }
}
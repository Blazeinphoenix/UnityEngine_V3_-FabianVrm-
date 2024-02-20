using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCon : MonoBehaviour
{
    public void TakeDamage(int amount)
    {
        print(transform.name + " HasAttacked " + amount + " Damage ");
        print("Success");
    }
}
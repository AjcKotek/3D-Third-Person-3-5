using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackBehaviour : MonoBehaviour
{
    public bool enemyAttacked;
    public int dmg;

    public float dmgTimer;

    private float dmgTime;

    private GameObject enemyReference;

    private void Update()
    {
        if (enemyAttacked)
        {
            dmgTime -= Time.deltaTime;
            if (dmgTime < 0)
            {
                enemyReference.GetComponent<EnemyBehaviour>().GetDamage(dmg);
                SetDmgTimer();
            }
        }
    }

    void SetDmgTimer()
    {
        dmgTime = dmgTimer;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemyAttacked = true;
            enemyReference = other.gameObject;
            dmgTime = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(("Enemy")))
        {
            enemyAttacked = false;
            enemyReference = null;
        }
    }

}

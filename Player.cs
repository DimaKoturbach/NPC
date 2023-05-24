using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;

    private int health = 10;
    private int coins = 0;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("health: " +  health); 
    }

    public void CollectCoins()
    {
        coins++;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}

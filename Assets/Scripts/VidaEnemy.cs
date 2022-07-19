using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemy : MonoBehaviour
{
    [SerializeField]
    private float enemyHealt;
    [SerializeField]
    

    private int killRoward;//the amout of money the player gets when this enemy
    private int damage;// the amount of damage the enemy does when it reaches the end

    private GameObject targetTile;
    void Start()
    {
        
    }
    private void Awake()
    {
        Enemies.enemies.Add(gameObject);
    }
   
    public void TakeDamage(float amount)
    {
        enemyHealt -= amount;
        if (enemyHealt <= 0)
        {
            Die();
        }

    }
    private void Die()
    {
        Enemies.enemies.Remove(gameObject);
        Destroy(transform.gameObject);
    }
    
  
}

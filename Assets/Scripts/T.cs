using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T : MonoBehaviour
{
    [SerializeField] private float range;
    [SerializeField] private float damage;
    [SerializeField] private float timeBetweenShots;
    public GameObject currentTarget;
    private float nextTimeToShoot;

    private void Start()
    {
        nextTimeToShoot = Time.time;
    }
    private void updateNeartestEnemy()
    {
        GameObject currentNearestEnemy = null;
        float distance = Mathf.Infinity;
        foreach (GameObject enemy in Enemies.enemies)
        {
            if (enemy != null)
            {
                float _distance = (transform.position - enemy.transform.position).magnitude;
                if (_distance < distance)
                {
                    distance = _distance;
                    currentNearestEnemy = enemy;
                }
            }
        }
        if (distance <= range)
        {
            currentTarget = currentNearestEnemy;
        }
        else
        {
            currentTarget = null;
        }
    }
    protected virtual void shoot()
    {
        if (currentTarget != null)
        {
            Enemy enemyScript = currentTarget.GetComponent<Enemy>();
            enemyScript.TakeDamage(damage);
        }
    }
    private void Update()
    {
        updateNeartestEnemy();
        if (Time.time >= nextTimeToShoot)
        {
            if (currentTarget != null)
            {
                shoot();
                nextTimeToShoot = Time.time + timeBetweenShots;
            }
        }

    }
}

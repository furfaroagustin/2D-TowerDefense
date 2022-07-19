using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTower : MonoBehaviour
{
    public Transform pivot;
    public Transform barrel;
    public Tower tower;
  
    void Start()
    {
        
    }

   
    void Update()
    {
        if(tower!=null)
        {
            Vector2 relative = tower.targetEnemy.transform.position - pivot.position;
            float angle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg;
            Vector3 newRotation = new Vector3(0, 0, angle);
            pivot.localRotation = Quaternion.Euler(newRotation);
        }
     
    }
}

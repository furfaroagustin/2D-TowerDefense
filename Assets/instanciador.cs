using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour
{

    public float tiempoCreacion = 8f;
   // public float tiempoCreacionn = 5f;
    public GameObject prefab;
    //public GameObject prefabEnemy;
    private int count = 0;
    void Start()
    {
        InvokeRepeating("Creando", 0.0F, tiempoCreacion);
        //InvokeRepeating("EnemyTwo", 0.0F, tiempoCreacionn);
    }
    void Creando()
    {
        GameObject cube = Instantiate(prefab, transform.position, transform.rotation) as GameObject;

        cube.name = "Perro" + count++;
    }
   /* void EnemyTwo()
    {
        //GameObject cube = Instantiate(prefabEnemy, transform.position, transform.rotation) as GameObject;

        cube.name = "Perro 2" + count++;

    }*/
}

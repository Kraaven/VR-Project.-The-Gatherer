using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;


public class FruitSpawner : MonoBehaviour
{
    public GameObject banana;

    public GameObject apple;

    public GameObject grape;

    public GameObject orange;
    
    
    // Start is called before the first frame update
    void Start()
    {
        setFruit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setFruit()
    {
        GameObject[] Fruits = {banana,apple,grape,orange};
        Instantiate(Fruits[Random.Range(0,4)], transform.position, Quaternion.identity);
    }
}

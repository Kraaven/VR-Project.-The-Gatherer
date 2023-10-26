using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnStart : MonoBehaviour
{
    public Vector3 rotation;
    void Awake()
    {
        transform.rotation = Quaternion.Euler(rotation);
    }
    
}

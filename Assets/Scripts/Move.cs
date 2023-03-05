using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    Vector3 v3force; 

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3force;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    int a = 1;
    [SerializeField]
    Vector3 v3force;
    [SerializeField]
    KeyCode J;


    private void OnCollisionStay(Collision collision)
    {
    if (Input.GetKey(J))
        if (a == 1) { 
        GetComponent<Rigidbody>().velocity += v3force;
                a = 0;
            }
    }
    private void OnCollisionExit(Collision collision)
    {
        a = 1;
    }



}

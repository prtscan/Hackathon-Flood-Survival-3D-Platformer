using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseLava : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 v3force;
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3force;
    }
    void OnCollisionEnter(Collision col)
    {
        {
            if (col.collider.tag != "Player")
            {
                Destroy(col.collider);
            }
                
        }
    }
}

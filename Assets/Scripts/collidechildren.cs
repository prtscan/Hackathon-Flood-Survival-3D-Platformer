using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidechildren : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform t in transform)
        {
            if (t == transform) continue; // Skip the transform itself
            t.gameObject.AddComponent<BoxCollider>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
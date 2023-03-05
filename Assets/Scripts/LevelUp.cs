using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    [SerializeField]
    string a;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        {
            if (col.collider.tag == "Player")
                Debug.Log("Collision Detected It Works");
                SceneManager.LoadScene(a);
        }
    }

}
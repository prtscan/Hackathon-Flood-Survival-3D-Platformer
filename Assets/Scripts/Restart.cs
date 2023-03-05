using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void FixedUpdate()
    {
        if (gameObject.transform.position.y <= -30)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
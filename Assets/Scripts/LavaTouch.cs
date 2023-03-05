using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LavaTouch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
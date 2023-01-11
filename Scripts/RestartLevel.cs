using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.lives--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);//ayný sahneyi baþtan baþlat.
        }

    }
}

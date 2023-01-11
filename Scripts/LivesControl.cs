using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class LivesControl : MonoBehaviour
{
    private void Awake()
    {
        switch (Score.lives) //can eksilti�inde kapat�lmas� gereken gameobjectlerden dolay� switch yaz�yoruz.
        {
            case 3:
                break;
            case 2:
                gameObject.transform.GetChild(2).gameObject.SetActive(false); //1 tanesini kapat�p 2 tanesi kalacak.
                break;
            case 1:
                gameObject.transform.GetChild(2).gameObject.SetActive(false); //2 tanesi kalacak.
                gameObject.transform.GetChild(1).gameObject.SetActive(false); //1 tanesi kalacak.
                break;
            case 0:
                SceneManager.LoadScene(0);
                break;
            default:
                break;
        }
    }
}

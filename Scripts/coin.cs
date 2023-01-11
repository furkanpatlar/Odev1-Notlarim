using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class coin : MonoBehaviour
{
    [SerializeField] private AudioClip clickSound;
    [SerializeField] private TextMeshProUGUI _text;
    private int count = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            count++;
            AudioSource.PlayClipAtPoint(clickSound, other.transform.position);
            Destroy(other.gameObject);
        }
    }

}

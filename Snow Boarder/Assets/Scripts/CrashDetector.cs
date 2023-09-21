using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float DelayTime = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && hasCrashed == false)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControl();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", DelayTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

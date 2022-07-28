using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishline : MonoBehaviour
{
    [SerializeField] ParticleSystem celebrate;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        celebrate.Play();
        Invoke("LevelFinisher", 1f); 
    }
    void LevelFinisher()
    {
        SceneManager.LoadScene(0);
    }
}

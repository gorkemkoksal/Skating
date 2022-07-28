using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashdetector : MonoBehaviour
{
    [SerializeField] float delay=0.5f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().LooseControl();
            Debug.Log("Ouch");
            Invoke("Deneme", delay);
        }
       
    }
    void Deneme()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem skateDrift;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.tag== "Ground")
        skateDrift.Play();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        skateDrift.Stop();
    }
}
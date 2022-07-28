using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float normalSpeed = 15f;
    [SerializeField] float boostedSpeed = 25f;
    [SerializeField] float torqAmount = 1f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            BoostPlayer();
        }
    }
    public void LooseControl()
    {
        canMove = false;
    }

    private void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed = boostedSpeed;
        }
        else surfaceEffector2D.speed = normalSpeed;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rb2d.AddTorque(torqAmount);
        else if (Input.GetKey(KeyCode.RightArrow))
            rb2d.AddTorque(-torqAmount);
    }
}

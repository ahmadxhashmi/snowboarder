using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float toqrueAmount = 1f;
    [SerializeField] float baseSpeed = 20f;
    [SerializeField] float boostSpeed = 50f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canplay = true;
    bool canMove = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            Rotateplayer();
            BoostPlayer();
        }
        
    }

    public void DisableControls()
    {
        canMove = false;
    }

    public void DisableDoublePlay()
    {
        canplay = false;
    }
    
    void BoostPlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void Rotateplayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-toqrueAmount);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(toqrueAmount);
        }
    }
}

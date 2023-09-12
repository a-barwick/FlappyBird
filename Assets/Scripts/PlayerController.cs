using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 1;
    
    private Rigidbody2D _rb;
    
    private void Start()
    {
        this._rb = gameObject.GetComponent<Rigidbody2D>();
        Debug.Log(this._rb);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)
            || Input.GetKeyDown(KeyCode.UpArrow)
            || Input.GetKeyDown(KeyCode.W))
        {
            this._rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Obstacle"))
        {
            
        }
    }
}

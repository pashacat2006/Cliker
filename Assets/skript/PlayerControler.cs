using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 3;
    private float jump = 300;
    public Rigidbody2D phy;
    public Animator animator;

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Left", false);
            phy.AddForce(transform.right * speed);
            animator.SetBool("Right",true);
        } else
        {
            animator.SetBool("Right", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Right", false);
            phy.AddForce(-transform.right * speed);
            animator.SetBool("Left", true);
        } else
        {
            animator.SetBool("Left",false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            phy.AddForce(transform.up * jump);
        }
    }
}

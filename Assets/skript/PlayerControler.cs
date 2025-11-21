using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]  private float speed = 3;
    private float jump = 300;
    public Rigidbody2D phy;
    public Animator animator;

    [SerializeField] private float _maxSpeed = 10;

    private void FixedUpdate()
    {
        Move();
        limitSpeed();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            phy.AddForce(transform.right * speed);
            animator.SetBool("Right",true);
            animator.SetBool("Left", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            phy.AddForce(-transform.right * speed);
            animator.SetBool("Left", true);
            animator.SetBool("Right", false);
        }
        else
        {
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            phy.AddForce(transform.up * jump);
        }
    }

    void limitSpeed()
    {
        if (phy.linearVelocity.magnitude > _maxSpeed)
        {
            phy.linearVelocity = phy.linearVelocity.normalized * _maxSpeed;
        }
    }
}

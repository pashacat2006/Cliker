using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]  private float speed = 3;
    private float jump = 400;
    public Rigidbody2D phy;
    public Animator animator;
    private bool gravity = true;
    [SerializeField] private float _maxSpeed = 10;


    private bool _isCollide = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _isCollide = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _isCollide = false;
    }

    private void FixedUpdate()
    {
        Move();
        limitSpeed();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isCollide && ship.GameOver == false)
        {
            print("paskacaty");
            if (gravity == true)
            {
                phy.gravityScale = -10;
                gravity = false;
            }
            else
            {
                phy.gravityScale = 10;
                gravity = true;
            }
        }
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.D)  && ship.GameOver == false)
        {
            phy.AddForce(transform.right * speed);
            animator.SetBool("Right",true);
            animator.SetBool("Left", false);
        }
        else if (Input.GetKey(KeyCode.A)  && ship.GameOver == false)
        {
            phy.AddForce(-transform.right * speed);
            animator.SetBool("Left", true);
            animator.SetBool("Right", false);
        }
    }

    void limitSpeed()
    {
        if (phy.velocity.magnitude > _maxSpeed)
        {
            phy.velocity = phy.velocity.normalized * _maxSpeed;
        }
    }
}

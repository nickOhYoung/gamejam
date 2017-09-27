using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveForce;

    public  float Jump;

    public int Health;

    public float maxSpeed;

    bool jumping = false;//判断人物是否跳起

    bool grounded = false;
    Transform groundCheck;
    SpriteRenderer _sprite;
    Rigidbody2D rb;

    float h;
    private void Start()
    {
        groundCheck = transform.Find("groundCheck");
      
        rb = this.GetComponent<Rigidbody2D>();
        _sprite = this.GetComponent<SpriteRenderer>();

    }

    private void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")) || Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Item"));
        if (Input.GetKeyDown(KeyCode.Space)&&grounded)
        {
            jumping = true;
        }
    }

    private void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");

        //设置角色起跳功能
        if (jumping)
        {
            rb.AddForce(new Vector2(0, Jump));
            jumping = false;
        }

        //角色行进
        if (h * rb.velocity.x < maxSpeed)
        {
            rb.AddForce(Vector2.right * h * moveForce);
            //rb.velocity = new Vector2(h * moveForce, rb.velocity.y);
        }

        
        if(Mathf.Abs(rb.velocity.x) > maxSpeed)
        {
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * maxSpeed, rb.velocity.y);
        }
        
    }

    void Flip()
    {
        if (h > 0)
        {
            _sprite.flipX = true;
        }
    }
}


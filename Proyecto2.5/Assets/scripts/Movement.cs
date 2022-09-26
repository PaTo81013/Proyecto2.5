using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D m_RigidBody;
    float m_speed;
    float movespeed = 10;
    int jumpsNumber;
    public int jumpsNumberValue;
    bool isGrounded;
    public Transform groundPositionCheck;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
       m_RigidBody= GetComponent<Rigidbody2D>();
        m_speed = 10f;
        jumpsNumber = jumpsNumberValue;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundPositionCheck.position, 0.1f, groundLayer); 
        if(isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpsNumber--;
                m_RigidBody.velocity = transform.up * m_speed;
            }
        }
        else if(jumpsNumber>0)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                jumpsNumber--;
                m_RigidBody.velocity = transform.up * m_speed;
            }
        }
        if(isGrounded&&m_RigidBody.velocity.y==0)
        {
            jumpsNumber = jumpsNumberValue;
        }
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0) * movespeed * Time.deltaTime);
        
    }

}

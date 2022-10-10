using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_RigidBody;
    [SerializeField] private float m_speed;
    [SerializeField] private float movespeed = 10;
    [SerializeField] private int jumpsNumber;
    [SerializeField] private int jumpsNumberValue;
    [SerializeField] private bool isGrounded;
    [SerializeField] private Transform groundPositionCheck;
    [SerializeField] private LayerMask groundLayer;
    
    void Start()
    {
       m_RigidBody= GetComponent<Rigidbody2D>();
        m_speed = 10f;
        jumpsNumber = jumpsNumberValue;
    }
    
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

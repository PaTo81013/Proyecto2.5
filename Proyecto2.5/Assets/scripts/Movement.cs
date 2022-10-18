using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _RigidBody;
    [SerializeField] private float _speed;
    [SerializeField] private float movespeed = 5;
    [SerializeField] private float _input;
    [SerializeField] private int _jumpsNumber;
    [SerializeField] private int _jumpsNumberValue;
    [SerializeField] private bool isGrounded;
    [SerializeField] private Transform groundPositionCheck;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
        _speed = 10f;
        _jumpsNumber = _jumpsNumberValue;
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundPositionCheck.position, 0.1f, groundLayer);
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _jumpsNumber--;
                _RigidBody.velocity = transform.up * _speed;
            }
        }

        else if (_jumpsNumber > 0)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _jumpsNumber--;
                _RigidBody.velocity = transform.up * _speed;
            }
        }

        if (isGrounded && _RigidBody.velocity.y == 0)
        {
            _jumpsNumber = _jumpsNumberValue;
        }
        //float horizontalInput = Input.GetAxis("Horizontal");
        
        //Vector2 _movespeed = m_RigidBody.velocity;
        //_movespeed.x = Input.GetAxisRaw("Horizontal") * m_speed;
        //m_RigidBody.velocity= _movespeed;

    }
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(_input, 0) * movespeed * Time.fixedDeltaTime);
    }

    public void moveLeft()
    {
        _input = -1;
    }
    public void moveRight()
    {
        _input = 1;
    }
    public void Resetleft()
    {
       if(_input==-1)
       {
            _input=0;
       }
       else
       {
            return;
       }
    }
    public void Resetright()
    {
        if (_input == 1)
        {
            _input = 0;
        }
        else
        {
            return;
        }
    }
}

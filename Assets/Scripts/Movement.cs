using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 5;
    Vector2 moveInput;
    
    Vector2 lookInput;
    public float JumpHeight = 50;
    public float RotationSpeed = 50;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
      rb = GetComponent<Rigidbody>();
      
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
    

    void FixedUpdate()
    {
        moveLogic();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    void OnLook(InputValue value)
    {
        // Vector2 lookInput = value.Get<Vector2>();
        // float mouseX = lookInput.x;
        // transform.Rotate(Vector3.up * mouseX * RotationSpeed * Time.deltaTime);
          // void Look()
    // {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * mouseX * RotationSpeed * Time.deltaTime);
    // }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("i jumped");
            transform.Translate(Vector3.up * JumpHeight * Time.fixedDeltaTime);
        }
    }

    void moveLogic()
    {
        Vector3 moveVector = new Vector3(moveInput.x, 0, moveInput.y) * MovementSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveVector);

        float move = Input.GetAxis("Vertical");
        float rotate = Input.GetAxis("Horizontal");
        Vector3 movement = transform.forward * move * MovementSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
        
        // Vector3 jumpVector = new Vector3(0, moveInput.y, 0) * JumpHeight * Time.fixedDeltaTime;
        // rb.MovePosition(rb.position + jumpVector);
    }
    


    //    if (Input.GetKey(KeyCode.W))
    //     {
    //         Debug.Log("W key was pressed");
    //         transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
    //     } 

    //     if (Input.GetKey(KeyCode.S))
    //     {
    //         Debug.Log("S key was pressed");
    //         transform.Translate(Vector3.back * MovementSpeed * Time.deltaTime);
    //     }

    //     if (Input.GetKey(KeyCode.A))
    //     {
    //         Debug.Log("A key was pressed");
    //         transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
    //     }

    //     if (Input.GetKey(KeyCode.D))
    //     {
    //         Debug.Log("D key was pressed");
    //         transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
    //     }

    //     if (Input.GetKey(KeyCode.Space))
    //     {
    //         Debug.Log("i jumped");
    //         transform.Translate(Vector3.up * JumpHeight * Time.deltaTime);
    //     }

    
  
}

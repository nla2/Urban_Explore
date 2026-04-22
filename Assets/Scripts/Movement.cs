using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 5;
    Vector2 moveInput;
    Vector2 lookInput;
    public float JumpHeight = 5;
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
        Vector2 lookInput = value.Get<Vector2>();
        float mouseX = lookInput.x;
        transform.Rotate(Vector3.up * mouseX * RotationSpeed * Time.deltaTime);
          // void Look()
    // {
    //     float mouseX = Input.GetAxis("Mouse X");
    //     transform.Rotate(Vector3.up * mouseX * RotationSpeed * Time.deltaTime);
    // }
    }
    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("i jumped");
            rb.AddForce(Vector3.up * JumpHeight * Time.deltaTime);
        }
    }

    void moveLogic()
    {
        Vector3 moveVector = new Vector3(moveInput.x, 0, moveInput.y) * MovementSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveVector);
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

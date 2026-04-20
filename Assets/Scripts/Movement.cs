using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
       if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W key was pressed");
            transform.Translate(Vector3.forward * MovementSpeed * Time.deltaTime);
        } 

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S key was pressed");
            transform.Translate(Vector3.back * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A key was pressed");
            transform.Translate(Vector3.left * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D key was pressed");
            transform.Translate(Vector3.right * MovementSpeed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables
    public float defaultSpeed;
    public float groundDrag;
    float moveSpeed;

    public float airSpeed;
    public float jumpForce;
    public float airDrag;
    public bool grounded = true;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        moveSpeed = defaultSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //sprint
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = defaultSpeed * 2.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = defaultSpeed;
        }

        //jump
        if (Input.GetKeyDown("space") && grounded == true)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            grounded = false;
        }

        MyInput();
        SpeedControl();

        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = airDrag;
        }
        
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //calc move direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if (grounded == true)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        else
        {
            rb.AddForce(moveDirection.normalized * airSpeed * 10f, ForceMode.Force);
        }
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //limit velo
        if (flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}



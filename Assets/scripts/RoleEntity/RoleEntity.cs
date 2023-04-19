using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleEntity : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public bool isGrounded = true;
    public Rigidbody rigidbody;

    // Update is called once per frame
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 2f;
        }
        else
        {
            moveSpeed = 5f;
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 roleMove = new Vector3(horizontal, 0f, vertical);
        transform.position += roleMove * moveSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpForce, rigidbody.velocity.z);
        isGrounded = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    }
}

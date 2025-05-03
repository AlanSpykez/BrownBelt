using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    Rigidbody rb;

    public float jumpForce = 5.7f;

    public bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z), Vector3.down, .55f);
        Debug.DrawRay(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), Vector3.down * .55f, Color.red);

        Debug.Log(Physics.RaycastAll(new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z), Vector3.down, .55f));

        if(Input.GetButtonDown("Jump") && isGrounded){
            Debug.Log("work please");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

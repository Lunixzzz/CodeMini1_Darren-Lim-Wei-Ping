using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    Rigidbody rb;

    public Transform groundChecker;
    public float checkRadius;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 moveBy = transform.right * x + transform.forward * z;

        rb.MovePosition(transform.position + moveBy.normalized * speed * Time.deltaTime);



        if (Input.GetKeyDown(KeyCode.Space) && isOnGround())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }


        bool isOnGround()
        {
            Collider[] colliders = Physics.OverlapSphere(groundChecker.position, checkRadius, groundLayer);

            if (colliders.Length > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if
        {

        }
    }
}

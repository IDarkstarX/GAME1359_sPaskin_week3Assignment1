using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    [SerializeField]
    float moveSpeed = 1;
    [SerializeField]
    float jumpSpeed = 100;
    [SerializeField]
    float gravity;

    Rigidbody rb;

    bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.down * gravity * rb.mass);

        canJump = false;

        Ray r = new Ray(transform.position, Vector3.down);

        RaycastHit hit;
        
        Debug.DrawLine(r.origin, r.origin + Vector3.down * 3);

        if(Physics.Raycast(r, out hit, 3))
        {
            if(hit.transform.tag == "walkable" && hit.transform != null)
            {
                canJump = true;
                
            }
            Debug.Log(hit.transform.name);
        }
        
        Debug.Log(canJump);

        //mobility//

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(h * moveSpeed, rb.velocity.y, v * moveSpeed);

        if(Input.GetButtonDown("Jump") && canJump) {

            Jump();
        }
    }

    void FixedUpdate()
    {

        
    }
    void Jump() {

        rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.y);
    }
}

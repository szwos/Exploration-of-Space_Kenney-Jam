using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0.1)
        {
            Rigidbody.MoveRotation(Rigidbody.rotation - 2);

        } else if(Input.GetAxis("Horizontal") < -0.1)
        {
            Rigidbody.MoveRotation(Rigidbody.rotation + 2);
        }

        //TODO: make Button Accelerate for this in project settings
        if(Input.GetKey(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector2.right * 5);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    [SerializeField]
    public Rigidbody2D playerRigidbody;
    public Transform CameraTransform;
    public Transform CameraTarget;
    public Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        
        CameraTransform = GetComponent<Transform>();
        cam = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        CameraTransform.position = new Vector3(CameraTarget.position.x, CameraTarget.position.y, CameraTransform.position.z);
        cam.orthographicSize = Mathf.Sqrt(playerRigidbody.velocity.magnitude) + 3;
    }
}

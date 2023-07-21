using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform CameraTransform;
    public Transform CameraTarget;

    // Start is called before the first frame update
    void Start()
    {
        CameraTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraTransform.position = new Vector3(CameraTarget.position.x, CameraTarget.position.y, CameraTransform.position.z);
    }
}

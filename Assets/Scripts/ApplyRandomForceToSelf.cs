using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ApplyRandomForceToSelf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector2(Random.Range(0, 5), Random.Range(0, 5)));
    }


}

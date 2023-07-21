using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyGlideForce : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public BoxCollider2D BoxCollider;

    //It's actually fluid density, but Lift SHOULD be proportional to this value in simple scenario
    //value of 5 is few times bigger than normal air density, this value will be taken from PlayerStats anyway
    public float LiftForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        BoxCollider = GetComponent<BoxCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {

        //unit Vector from transform.rotation, 
        //this vector will be projected on the other one 
        Vector2 gliderUnitVector = transform.rotation * Vector2.right;

        //gliderUnitVecotr multiplied by magnitude(BoxCollider length)
        Vector2 gliderVector = gliderUnitVector * BoxCollider.size.x;

        //TODO: actually there is no need to normalize this vector, calculations should be correct anyway
        //unit vector from Rigidbody.velocity (just normalize it), rotated 90 degree
        //projection will be done upon this vector
        Vector2 frontalLengthUnitVector = rotateVector(Rigidbody.velocity.normalized, 90);

        //gliderUnitVector rotated by 90 degree, it will be multiplied by dragForceMagnitude later
        Vector2 dragUnitVector = rotateVector(gliderUnitVector, 90);

        
        //for some reason following the original equation produced infinite speeds
        /*float dotProductSquared = Vector2.Dot(gliderVector, frontalLengthUnitVector);
        dotProductSquared *= dotProductSquared;
        float dragForceMagnitude =
            0.5f *
            LiftForce *
            Rigidbody.velocity.magnitude * Rigidbody.velocity.magnitude *
            dotProductSquared;
            //(gliderVector.x * frontalLengthUnitVector.x + gliderVector.y * frontalLengthUnitVector.y);*/

        float dragForceMagnitude =
            0.5f *
            LiftForce *
            Rigidbody.velocity.magnitude *
            Vector2.Dot(gliderVector, frontalLengthUnitVector);

        Debug.Log(dragForceMagnitude);

        if(dragForceMagnitude > 5)
        {
            Debug.Log("Zesra³o sie");
        }

        Rigidbody.AddForce(dragUnitVector * dragForceMagnitude);
    }

    /// <summary>
    /// angle is in degrees
    /// </summary>
    private Vector2 rotateVector(Vector2 vec, float angle)
    {
        float newAngle = Mathf.Atan2(vec.y, vec.x) + angle * Mathf.Deg2Rad;
        return new Vector2(Mathf.Cos(newAngle), Mathf.Sin(newAngle));
    }
}

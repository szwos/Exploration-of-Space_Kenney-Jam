using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int timeRangeVertical = 100;
    public int timeRangeHorizontal = 500;

    [SerializeField, Range(0, 1)]
    public int horizontalSwitch = 1;


    [SerializeField, Range(1, 100)]
    public float horizontalRange = 1;

    [SerializeField, Range(1, 100)]
    public float verticalRange = 1;

    private float tHorizontal = 0;
    private float tVertical = 0;

    // Update is called once per frame
    void Update()
    {
        if(tHorizontal > timeRangeHorizontal)
            tHorizontal = 0;
        if(tVertical > timeRangeVertical)
            tVertical = 0;


        transform.position = new Vector3(
            (transform.position.x + Mathf.Cos(((float)tHorizontal / (float)timeRangeHorizontal) * Mathf.PI * 2) / horizontalRange) * horizontalSwitch,
            (transform.position.y + Mathf.Cos(((float)tVertical / (float)timeRangeVertical) * Mathf.PI * 2) / verticalRange) * horizontalSwitch,
            transform.position.z);

        tHorizontal++;
        tVertical++;
    }

   
}

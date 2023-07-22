using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopuleCollision : MonoBehaviour
{
    private EnemyBehaviour parent;

    private void Start()
    {
        parent = GetComponentInParent<EnemyBehaviour>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        parent.HandleCopuleCollision();
        Destroy(this); //This works only once, so CopuleCollision component is not needed after detaching
    }
}

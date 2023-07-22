using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject CopuleAfterDeathPrefab;
    public GameObject BodyAfterDeathPrefab;

    public void HandleCopuleCollision()
    {
        /*Instantiate(CopuleAfterDeathPrefab);
        Instantiate(BodyAfterDeathPrefab);*/

        //for some reason this produces a lag but it's a game jam -\_(O_o)_/-
        //TODO: emiting them as particles could solve this
        for (int i = transform.childCount-1; i >= 0; i--)
        {
            Transform child = transform.GetChild(i);
            child.transform.parent = null; //this detaches from parent
            Rigidbody2D childRb = child.AddComponent<Rigidbody2D>();
            childRb.AddForce(new Vector2(Random.Range(0f, 100f), Random.Range(0f, 100f)));
            childRb.angularVelocity = Random.Range(0f, 1f) * Mathf.PI * 2;
        }

        //TODO: maybe emit some particles

        Destroy(gameObject);
    }
}

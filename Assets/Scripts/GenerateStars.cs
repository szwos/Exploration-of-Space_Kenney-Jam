using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStars : MonoBehaviour
{
    [SerializeField]
    public int count;

    //for quick and easy modification of spawning space
    [SerializeField]
    public BoxCollider2D bounds;

    [SerializeField]
    public List<GameObject> starTemplates = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        bounds  = GetComponent<BoxCollider2D>();


        for(int i = 0; i < count; i++)
        {
            Instantiate(starTemplates[
                    Random.Range(0, starTemplates.Count - 1)],
                    new Vector3(
                        Random.Range(
                            transform.position.x - bounds.bounds.size.x / 2,
                            transform.position.x + bounds.bounds.size.x - bounds.bounds.size.x / 2),
                        Random.Range(
                            transform.position.y - bounds.bounds.size.y / 2,
                            transform.position.y + bounds.bounds.size.y - bounds.bounds.size.y / 2),
                        0),
                    transform.rotation);
        }
    }

   
}

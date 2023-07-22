using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public float secondsTillReload = 3;


    //TODO: display upgrades menu
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Enemy"))
        {
            StartCoroutine(reloadAfterSeconds());
        }
    }

    private IEnumerator reloadAfterSeconds()
    {

        GetComponent<ApplyGlideForce>().enabled = false;
        GetComponent<PlayerController>().enabled = false;

        yield return new WaitForSeconds(secondsTillReload);
        

        SceneManager.LoadSceneAsync(0);

    
    }
}

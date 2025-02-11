using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script check if trigger enters and exits are from enemies. On enter, activates enemy. On exit, deactivates enemy.
public class PlayerActivateEnemy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Enemy") || coll.CompareTag("Boss"))
        {
            var transform = coll.GetComponent<Transform>();
            for (int a = 0; a < transform.childCount; a++)
            {
                transform.GetChild(a).gameObject.SetActive(true);
            }
        }
    }
    
    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            var transform = coll.GetComponent<Transform>();
            for (int a = 0; a < transform.childCount; a++)
            {
                transform.GetChild(a).gameObject.SetActive(false);
            }
           
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    public Vector3 item_position;
    private Object thisObject;
    public Vector3 respawnPosition;

    private void Awake()
    {
        thisObject = GetComponent<Object>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerCollider"))
        {
<<<<<<< Updated upstream
            Collect();
            RespawnItem();
=======
            gameObject.SetActive(false);
            transform.position = respawnPosition;
        }
        else
        {
            gameObject.SetActive(true);
>>>>>>> Stashed changes
        }
    }

    private void Collect()
    {
        gameObject.SetActive(false);
        Invoke("RespawnItem", 2f);
    }

    private void RespawnItem()
    {
        transform.position = item_position;
        gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{
    public LayerMask layer_to_scan_for;
    private bool is_hidden = false;
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //debug info
        Debug.DrawRay(transform.position, transform.forward * 0.1f, Color.green);

        if (BehindObject())
        {
            if (Input.GetKey(KeyCode.Space))
            {
                is_hidden = true;
                sprite.color = new Color(0, 1, 0, 1);

                Debug.Log("Space");
            }

            else
            {
                is_hidden = false;
            }
        }
        else
        {
            is_hidden = false;
        }
        /*if(Input.GetKey(KeyCode.Space)) //&& BehindObject())
        {
            is_hidden = true;
            sprite.color = new Color(0, 1, 0, 1);

            Debug.Log("space");
        }
        else
        {
            is_hidden = false;
        }*/

    }

    bool BehindObject()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 0.1f, layer_to_scan_for))
        {
            Debug.Log("Check");
            return true;
        }
        return false; 
    }

    public bool Hidden()
    {
        return is_hidden;
    }

    void OnCollisionEnter(Collision coll)
    {
        print("here");
    }
}

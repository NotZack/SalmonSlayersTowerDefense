using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpearTowerBehavior : MonoBehaviour
{
    bool placed = false;
    bool colliding = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (placed)
        {
            // Get the fish
        }
        else
        {
            if (!Input.GetMouseButtonDown(0))
            {
                Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = (pos);
            }
            else
            {
                if (!colliding)
                {
                    placed = true;
                }
                else
                {
                    //Debug.Log("COLLIDING WITH STREAM");
                }
                
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        colliding = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        colliding = false;
    }
}

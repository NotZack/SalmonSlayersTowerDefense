using UnityEngine;

public class SpearTowerBehavior : TowerBehavior
{
    void Start(){ commonStart(); }

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
                    GetComponent<Collider2D>().isTrigger = false;
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

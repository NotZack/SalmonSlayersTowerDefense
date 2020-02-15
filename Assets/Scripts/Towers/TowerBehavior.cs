using UnityEngine;

public abstract class TowerBehavior : MonoBehaviour
{

    internal bool placed = false;
    internal bool colliding = false;

    internal void commonStart()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = GameCoordinator.incrementSortingOrder();
    }

    void OnMouseDown()
    {
        if (placed)
        {
            MenuCoordinator.switchMenu(false);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

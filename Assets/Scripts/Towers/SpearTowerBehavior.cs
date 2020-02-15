using UnityEngine;

public class SpearTowerBehavior : Tower
{

    private void Awake()
    {
        commonStart();
        cost = 500;
        range = 2;
        currentTier = 1;
        maxUpgradeTier = 2;
        nextUpgradeCost = 600;
    }
    void Start(){}

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
    internal override bool isUpgradable()
    {
        return currentTier < maxUpgradeTier;
    }
    internal override void upgrade()
    {
        if (isUpgradable())
        {
            currentTier++;
            cost = nextUpgradeCost;
            nextUpgradeCost *= 2;
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

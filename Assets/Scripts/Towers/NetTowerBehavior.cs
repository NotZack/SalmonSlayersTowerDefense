using UnityEngine;

public class NetTowerBehavior : Tower
{

    private void Awake()
    {
        commonStart();
        cost = Tower.netTowerBaseCost;
        range = 2;
        currentTier = 1;
        maxUpgradeTier = 2;
        nextUpgradeCost = 700;
    }

    void Start(){
        GameCoordinator.changeGoldBalance(-cost);
    }

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
            GameCoordinator.changeGoldBalance(-nextUpgradeCost);
            currentTier++;
            cost = nextUpgradeCost;
            nextUpgradeCost *= 2;
            UpgradeScript.refreshButton();
            UpgradeCostUpdate.updateCost();
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

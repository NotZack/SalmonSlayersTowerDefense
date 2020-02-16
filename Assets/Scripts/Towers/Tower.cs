using UnityEngine;

public class Tower : MonoBehaviour
{
    internal const int netTowerBaseCost = 300;
    internal const int spearTowerBaseCost = 500;

    //Stat variables
    internal int range;
    internal int cost;
    internal double reelInRate;

    internal int nextUpgradeCost;
    internal int currentTier;
    internal int maxUpgradeTier;

    //Behavioral variables
    internal bool placed = false;
    internal bool colliding = false;

    internal bool firstHit = false;

    internal CommonFish target = null;

    internal virtual void Start()
    {
        GameCoordinator.changeGoldBalance(-cost);
    }

    internal void commonStart()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = GameCoordinator.incrementSortingOrder();
        currentTier = 1;
    }
    internal bool isUpgradable()
    {
        return currentTier < maxUpgradeTier;
    }
    internal void upgrade()
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

    internal void sellTower()
    {
        Destroy(this.gameObject);
        GameCoordinator.selectedTower = null;
        MenuCoordinator.switchMenu(false);
        GameCoordinator.changeGoldBalance(cost / 2);
    }

    internal void moveTower()
    {
        placed = false;
    }

    internal CommonFish getNewestTarget()
    {
        foreach (CommonFish fish in WaveCoordinator.getFishList())
        {
            if (isInRange(fish))
            {
                return fish;
            }
        }
        return null;
    }

    internal bool isInRange(CommonFish fish)
    {
        Vector2 currentPos = transform.position;
        if (fish != null)
        {
            float dist = Vector2.Distance(fish.transform.position, currentPos);
            if (dist < range)
            {
                return true;
            }
        }
        return false;
    }

    void OnMouseDown()
    {
        if (placed)
        {
            GameCoordinator.setSelectedTower(this);
            UpgradeCostUpdate.updateCost();
            MenuCoordinator.switchMenu(false);
        }
    }

    int counter = 100;

    internal virtual void Update()
    {
        if (placed)
        {
            if (target == null)
            {
                target = getNewestTarget();
            }
            else if (isInRange(target))
            {
                if (counter >= reelInRate * 80)
                {
                    target.reelIn(1);
                    counter = 0;
                }
                counter++;
            }
            else
            {
                target = null;
                counter = 100;
            }
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
}
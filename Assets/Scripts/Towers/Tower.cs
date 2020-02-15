using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    internal const int netTowerBaseCost = 300;
    internal const int spearTowerBaseCost = 500;

    //Stat variables
    internal int range;
    internal int cost;

    internal int nextUpgradeCost;
    internal int currentTier;
    internal int maxUpgradeTier;

    //Behavioral variables
    internal bool placed = false;
    internal bool colliding = false;

    internal void commonStart()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = GameCoordinator.incrementSortingOrder();
    }

    internal abstract bool isUpgradable();
    internal abstract void upgrade();

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
    void OnMouseDown()
    {
        if (placed)
        {
            GameCoordinator.setSelectedTower(this);
            UpgradeCostUpdate.updateCost();
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

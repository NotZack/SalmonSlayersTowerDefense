using UnityEngine;

public class GameCoordinator : MonoBehaviour
{

    static int currentSortingLayer = 1;
    static int goldBalance = 1000;

    internal static Tower selectedTower = null;
    
    void Start() {}

    void Update() {}

    internal static int incrementSortingOrder()
    {
        currentSortingLayer++;
        return currentSortingLayer;
    }

    internal static void setSelectedTower(Tower tower)
    {
        selectedTower = tower;
    }

    internal static Tower getSelectedTower()
    {
        return selectedTower;
    }

    public void upgradeSelectedTower()
    {
        selectedTower.upgrade();
    }

    public void sellSelectedTower()
    {
        selectedTower.sellTower();
    }

    public void moveSelectedTower()
    {
        selectedTower.moveTower();
    }

    internal static void changeGoldBalance(int amount)
    {
        goldBalance += amount;
    }

    internal static int getGoldBalance()
    {
        return goldBalance;
    }

    internal static GameObject createSpearTower()
    {
        GameObject spearTower = (GameObject)Instantiate(Resources.Load("SpearTower"));
        return spearTower;
    }

    internal static GameObject createNetTower()
    {
        GameObject netTower = (GameObject)Instantiate(Resources.Load("NetTower"));
        return netTower;
    }
}

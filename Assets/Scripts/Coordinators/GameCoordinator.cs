using UnityEngine;

public class GameCoordinator : MonoBehaviour
{

    static int currentSortingLayer = 1;
    
    void Start() {}

    void Update() {}

    internal static int incrementSortingOrder()
    {
        currentSortingLayer++;
        return currentSortingLayer;
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

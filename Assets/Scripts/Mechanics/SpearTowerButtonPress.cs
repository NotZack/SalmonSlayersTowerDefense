using UnityEngine;

public class SpearTowerButtonPress : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        
    }

    public void ButtonInteract()
    {
        if (GameCoordinator.getGoldBalance() >= Tower.spearTowerBaseCost)
        {
            GameCoordinator.createSpearTower();
        } 
    }
}
using UnityEngine;
using UnityEngine.UI;

public class NetTowerButtonPress : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {

    }

    public void ButtonInteract()
    {
        if (GameCoordinator.getGoldBalance() >= Tower.netTowerBaseCost)
        {
            GameCoordinator.createNetTower();
        }
    }
}

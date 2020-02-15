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
        GameCoordinator.createNetTower();
    }
}

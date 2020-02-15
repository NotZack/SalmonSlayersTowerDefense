using UnityEngine;
using UnityEngine.UI;

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
        GameCoordinator.createSpearTower();
    }
}
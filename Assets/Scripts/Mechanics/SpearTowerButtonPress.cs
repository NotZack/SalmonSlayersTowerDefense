using UnityEngine;
using System.Collections;

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
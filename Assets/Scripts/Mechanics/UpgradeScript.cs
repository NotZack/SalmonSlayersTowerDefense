using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    bool upgradeEnabled = false;
    void Start()
    {
    }

    void Update()
    {
        if (GameCoordinator.getSelectedTower() != null && GameCoordinator.getSelectedTower().isUpgradable())
        {
            upgradeEnabled = true;
            GetComponent<Button>().interactable = true;
        }
        else
        {
            upgradeEnabled = false;
            GetComponent<Button>().interactable = false;
        }
    }
}

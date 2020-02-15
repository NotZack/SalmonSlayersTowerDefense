using UnityEngine;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{

    static Button upgradeButton;

    void Start()
    {
        upgradeButton = GetComponent<Button>();
    }

    void Update()
    {
    }

    internal static void refreshButton()
    {
        if (GameCoordinator.getSelectedTower() != null && GameCoordinator.getSelectedTower().isUpgradable())
        {
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeButton.interactable = false;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        if (GameCoordinator.getSelectedTower() != null && GameCoordinator.getSelectedTower().isUpgradable())
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }
}

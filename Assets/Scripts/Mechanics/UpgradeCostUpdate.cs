using UnityEngine;
using UnityEngine.UI;

public class UpgradeCostUpdate : MonoBehaviour
{

    public static Text cost;

    // Start is called before the first frame update
    void Start()
    {
        cost = GetComponent<Text>();
        updateCost(); 
    }

    internal static void updateCost()
    {
        if (GameCoordinator.getSelectedTower() != null)
        {
            string upgradeCost = GameCoordinator.getSelectedTower().nextUpgradeCost.ToString();
            cost.text = "Cost: " + upgradeCost;
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}

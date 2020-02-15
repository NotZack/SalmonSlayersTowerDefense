using UnityEngine.UI;
using UnityEngine;

public class GoldBalanceUpdate : MonoBehaviour
{
    Text goldText;

    // Start is called before the first frame update
    void Start()
    {
        goldText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string goldAmount = GameCoordinator.getGoldBalance().ToString();
        goldText.text = "Gold: " + goldAmount;
    }
}

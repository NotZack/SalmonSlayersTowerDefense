using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NetTowerCost : MonoBehaviour
{
    public Text cost;

    void Start()
    {
        cost.text = Tower.netTowerBaseCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

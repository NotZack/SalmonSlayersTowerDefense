using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpearTowerCost : MonoBehaviour
{
    public Text cost;

    void Start()
    {
        cost.text = Tower.spearTowerBaseCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

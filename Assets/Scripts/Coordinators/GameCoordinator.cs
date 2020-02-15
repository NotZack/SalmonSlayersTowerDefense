using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCoordinator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal static GameObject createSpearTower()
    {
        GameObject spearTower = (GameObject)Instantiate(Resources.Load("SpearTower"));
        return spearTower;
    }

    internal static GameObject createNetTower()
    {
        GameObject netTower = (GameObject)Instantiate(Resources.Load("NetTower"));
        return netTower;
    }
}

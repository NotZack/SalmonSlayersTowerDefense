using System;
using System.Collections.Generic;
using UnityEngine;

public class WaveCoordinator : MonoBehaviour
{
    static int waveNumber = 1;

    static List<GameObject> fishList = new List<GameObject>();

    internal static int getWaveNumber()
    {
        return waveNumber;
    }

    internal static List<GameObject> getFishList()
    {
        return fishList;
    }

    void Start()
    {
        if (waveNumber == 1)
        {
            fishList.Add(
                (GameObject)Instantiate(Resources.Load("Clownfish"))
            );
        }
    }

    void Update()
    {
        
    }
}

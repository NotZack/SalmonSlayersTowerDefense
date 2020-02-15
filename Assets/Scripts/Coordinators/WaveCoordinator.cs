using System;
using System.Collections.Generic;
using UnityEngine;

public class WaveCoordinator : MonoBehaviour
{
    static int waveNumber = 1;

    static List<CommonFish> fishList = new List<CommonFish>();

    internal static int getWaveNumber()
    {
        return waveNumber;
    }

    internal static List<CommonFish> getFishList()
    {
        return fishList;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

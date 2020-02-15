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
        if (waveNumber == 1)
        {
            fishList.Add(Instantiate(Resources.Load("Clownfish") as GameObject).GetComponent<Clownfish>());
            

        }
    }

    int counter = 0;

    void Update()
    {
        counter++;

        if (counter >= (60 + UnityEngine.Random.Range(-4.5f, 5f)))
        {
            fishList.Add(Instantiate(Resources.Load("Clownfish") as GameObject).GetComponent<Clownfish>());
            counter = 0;
        }
    }
}

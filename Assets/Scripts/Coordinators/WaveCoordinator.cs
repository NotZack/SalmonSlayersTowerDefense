using System;
using System.Collections.Generic;
using UnityEngine;

public class WaveCoordinator : MonoBehaviour
{
    static int waveNumber = 1;

    static List<CommonFish> fishList = new List<CommonFish>();

    static bool waveDone;

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
            fishList.Add(Instantiate(Resources.Load("SwordFish") as GameObject).GetComponent<SwordFish>());
            fishList.Add(Instantiate(Resources.Load("Salmon") as GameObject).GetComponent<Salmon>());
            fishList.Add(Instantiate(Resources.Load("Shark") as GameObject).GetComponent<Shark>());
        }
    }

    int counter = 0;

    //Method for each wave that needs a parameter of each wave incrementing the waveNumber at the end by 1
    internal int WaveMaker(int waveNumber)
    {

        waveNumber++;
        return waveNumber;
    }


    void Update()
    {
        counter++;

        if(Input.GetMouseButtonDown(0) && waveDone)
        {
            
        }


        if (counter >= (60 + UnityEngine.Random.Range(-4.5f, 5f)))
        {
            fishList.Add(Instantiate(Resources.Load("Clownfish") as GameObject).GetComponent<Clownfish>());
            counter = 0;
        }
    }
}

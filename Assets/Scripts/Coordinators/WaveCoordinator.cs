using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaveCoordinator : MonoBehaviour
{
    static int waveNumber = 1;

    static bool startWave = false;

    static List<CommonFish> fishList = new List<CommonFish>();

    static List<CommonFish> nextWave = new List<CommonFish>();

    static bool waveDone;

    internal static int getWaveNumber()
    {
        return waveNumber;
    }

    internal static int getNumLeft()
    {
        return nextWave.Count;
    }

    internal static List<CommonFish> getFishList()
    {
        return fishList;
    }

    void Start()
    {
        openWave();
        nextWave = createWave(UnityEngine.Random.Range(1, 10));
        
    }

    List<CommonFish> createWave(int difficulty)
    {
        List<CommonFish> waveInhabitants = new List<CommonFish>();
        for (int i = 0; i < difficulty; i++)
        {
            if (UnityEngine.Random.Range(0, 20) == 1)
            {
                waveInhabitants.Add((Resources.Load("Shark") as GameObject).GetComponent<Shark>());
            }
            else
            {
                waveInhabitants.Add((Resources.Load("Clownfish") as GameObject).GetComponent<Clownfish>());
            }

            if (UnityEngine.Random.Range(0, 5) == 1)
            {
                waveInhabitants.Add((Resources.Load("SwordFish") as GameObject).GetComponent<SwordFish>());
            }
            else
            {
                waveInhabitants.Add((Resources.Load("Salmon") as GameObject).GetComponent<Salmon>());
            }
        }
        int bulkSize = (waveNumber * 10) + 10;
        for (int j = 0; j < bulkSize; j++)
        {
            if (bulkSize * 0.4 < j)
            {
                waveInhabitants.Add((Resources.Load("Clownfish") as GameObject).GetComponent<Clownfish>());
            }
            else if (bulkSize * 0.95 < j)
            {
                waveInhabitants.Add((Resources.Load("Salmon") as GameObject).GetComponent<Salmon>());
            }
        }
        waveInhabitants = waveInhabitants.OrderBy(x => UnityEngine.Random.value).ToList();
        return waveInhabitants;
    }

    public void openWave()
    {
        startWave = true;
    }

    int counter = 0;
    void Update()
    {

        if (startWave && nextWave.Count > 0)
        {
            if (counter >= (60 + UnityEngine.Random.Range(-50, 50)))
            {
                fishList.Add(Instantiate(nextWave[0]));
                nextWave.RemoveAt(0);
                counter = 0;

                if (nextWave.Count == 0)
                {
                    waveNumber++;
                    counter = 0;
                    startWave = false;
                }
            }
            counter++;
        } 
        else if (nextWave.Count == 0)
        {
           nextWave = createWave(UnityEngine.Random.Range(1, 10) * waveNumber);
        }
    }
}

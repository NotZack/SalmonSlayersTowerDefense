using System;
using System.Collections.Generic;
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

    //Input is arbitrary difficulty number 1-100, 1 being easiest 100 being hardest.
    List<CommonFish> createWave(int difficulty)
    {
        List<CommonFish> waveInhabitants = new List<CommonFish>();
        for (int i = 0; i < difficulty; i++)
        {
            if (UnityEngine.Random.Range(0, 9) == 1)
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
        return waveInhabitants;
    }

    public void openWave()
    {
        if (nextWave.Count == 0)
        {
            startWave = true;
            Debug.Log("HERE");
        }
    }

    int counter = 0;
    void Update()
    {
        counter++;

        if (startWave && nextWave.Count > 0)
        {
            if (counter >= (60 + UnityEngine.Random.Range(-50, 50)))
            {
                fishList.Add(Instantiate(nextWave[0]));
                nextWave.RemoveAt(0);
                counter = 0;

                if (fishList.Count == 0)
                {
                    waveNumber++;
                    startWave = false;
                }
            }
        } 
        else
        {
            createWave(UnityEngine.Random.Range(1, 10) * waveNumber);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateWaveCounter : MonoBehaviour
{

    Text waveText;

    void Start()
    {
        waveText = GetComponent<Text>();
        updateWaveText();
    }

    internal void updateWaveText()
    {
        string waveNum = WaveCoordinator.getWaveNumber().ToString();
        waveText.text = "Wave: " + waveNum;
    }
    void Update()
    {
        updateWaveText();
    }
}

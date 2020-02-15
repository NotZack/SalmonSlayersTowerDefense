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
        string waveNum = GameCoordinator.getWaveNumber().ToString();
        waveText.text = "Wave: " + waveNum;
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveNumLeftUpdate : MonoBehaviour
{
    Text numLeftText;
    void Start()
    {
        numLeftText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string left = WaveCoordinator.getNumLeft().ToString();
        numLeftText.text = left + " left";
    }
}

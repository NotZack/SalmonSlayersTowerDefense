using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelCaught : MonoBehaviour
{
    private static int totalCaught = 0;
    public static Text caught;

    void Start()
    {
        caught = GetComponent<Text>();
    }

    internal static void updateCaughtText(int newCatch)
    {
        totalCaught += newCatch;
        caught.text = "Caught: " + totalCaught.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

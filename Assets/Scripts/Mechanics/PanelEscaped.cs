using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelEscaped : MonoBehaviour
{
    private static int totalEsc;
    public static Text Escaped;

    // Start is called before the first frame update
    void Start()
    {
        Escaped = GetComponent<Text>();
    }
    //A method that is called in FollowThePath.cs which takes in the parameter of the type of fish in every instance.
    internal static void EscapedFish(CommonFish crossedFish)
    {
        //Creates a variable string set to the weight of the instance of the fish
        totalEsc += crossedFish.weight;
        //Updates the escaped text to include the weight of the fish.
        Escaped.text = "Escaped: " + totalEsc;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

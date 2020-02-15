using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelEscaped : MonoBehaviour
{

    public static Text Escaped;

    // Start is called before the first frame update
    void Start()
    {
        Escaped = GetComponent<Text>();
        Debug.Log(Escaped);

    }
    //A method that is called in FollowThePath.cs which takes in the parameter of the type of fish in every instance.
    internal static void EscapedFish(CommonFish crossedFish)
    {
        //Creates a variable string set to the weight of the instance of the fish
        string fishEsc = crossedFish.weight.ToString();
        //Updates the escaped text to include the weight of the fish.
        Escaped.text = "Escaped: " + fishEsc;
        Debug.Log(Escaped.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

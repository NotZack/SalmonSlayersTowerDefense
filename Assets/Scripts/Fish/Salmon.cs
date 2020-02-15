using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salmon : CommonFish
{
    
    void Awake()
    {
        movementSpeed = 10;
        weight = 5;
        inAir = false;
        inWater = true;
        canBoth = true;
    }

    internal override void Start()
    {
        base.Start();
    }

    internal override void Update()
    {
        base.Update();
    }
}

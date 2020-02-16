using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingFish : CommonFish
{
    void Awake()
    {
        movementSpeed = 20;
        weight = 1;
        inAir = true;
        inWater = false;
        canBoth = false;
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

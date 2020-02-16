using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : CommonFish
{
    void Awake()
    {
        movementSpeed = 3;
        weight = 50;
        inAir = false;
        inWater = true;
        canBoth = true;
        reward = 500;
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

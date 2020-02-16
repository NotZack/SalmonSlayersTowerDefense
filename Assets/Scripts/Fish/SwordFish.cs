using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordFish : CommonFish
{
    void Awake()
    {
        movementSpeed = 15;
        weight = 5;
        inAir = true;
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

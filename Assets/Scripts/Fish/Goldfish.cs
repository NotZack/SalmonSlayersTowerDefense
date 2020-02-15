using UnityEngine;

public class Goldfish : CommonFish
{
    void Awake()
    {
        movementSpeed = 15;
        weight = 2;
        inAir = false;
        inWater = true;
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

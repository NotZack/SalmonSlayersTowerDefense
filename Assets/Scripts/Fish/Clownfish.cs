using UnityEngine;

public class Clownfish : CommonFish
{
    void Awake()
    {
        movementSpeed = 5;
        weight = 2;
        inAir = false;
        inWater = true;
        canBoth = false;
        reward = 10;
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

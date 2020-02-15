using UnityEngine;

public abstract class CommonFish : MonoBehaviour
{
    internal int movementSpeed;
    internal int weight;
    internal bool inAir;
    internal bool inWater;
    internal bool canBoth;

    internal int reeledInAmount;

    internal void reelIn(int reelAmount)
    {
        reeledInAmount += reelAmount;
        if (reeledInAmount >= weight)
        {
            getCaught();
        }
    }

    void getCaught()
    {

    }

    internal virtual void Start()
    {}

    internal virtual void Update()
    { }

    else if (waypointIndex == waypoints.Length)
        {
            PanelEscaped.EscapedFish(this);
    }
}

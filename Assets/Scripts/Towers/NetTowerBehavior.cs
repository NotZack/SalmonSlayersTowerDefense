using UnityEngine;

public class NetTowerBehavior : Tower
{

    private void Awake()
    {
        commonStart();
        
        reelInRate = 1;
        range = 2;

        cost = Tower.netTowerBaseCost;
        maxUpgradeTier = 2;
        nextUpgradeCost = 700;
        cooldownTimer = (float) reelInRate;
    }

    internal override void Start()
    {
        base.Start();
    }

    internal override void Update()
    {
        base.Update();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        colliding = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        colliding = false;
    }
}

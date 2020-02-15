using UnityEngine;

public class SpearTowerBehavior : Tower
{

    private void Awake()
    {
        commonStart();
        
        reelInRate = 0.5;
        range = 2;

        cost = Tower.spearTowerBaseCost;
        maxUpgradeTier = 3;
        nextUpgradeCost = 600;

        cooldownTimer = (float)reelInRate;
    }

    internal override void Start(){
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

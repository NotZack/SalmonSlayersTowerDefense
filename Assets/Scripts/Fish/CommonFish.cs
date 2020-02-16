using System.Collections.Generic;
using UnityEngine;

public abstract class CommonFish : MonoBehaviour
{
    internal int movementSpeed;
    internal int weight;
    internal bool inAir;
    internal bool inWater;
    internal bool canBoth;

    internal int reeledInAmount;

    bool colored = false;

    private Renderer rend;
    private Color colorToTurnTo = Color.red;

    //Movement variables
    private List<Transform> waypoints = new List<Transform>();

    private int waypointIndex = 0;

    internal void reelIn(int reelAmount)
    {
        flashColor();
        reeledInAmount += reelAmount;
        if (reeledInAmount >= weight)
        {
            getCaught();
        }
    }

    void flashColor()
    {
        rend.material.color = colorToTurnTo;
        colored = true;
    }

    void getCaught()
    {
        Destroy(this.gameObject);
    }

    internal virtual void Start()
    {

        rend = GetComponent<Renderer>();
        for (int i = 0; i < 24; i ++)
        {
            if (i == 0)
            {
                waypoints.Add(((GameObject)Instantiate(GameObject.Find("Waypoint"))).transform);
            }
            else
            {
                waypoints.Add(((GameObject)Instantiate(GameObject.Find("Waypoint" + " (" + i + ")"))).transform);
            }
        }
        transform.position = waypoints[waypointIndex].transform.position;
    }

    internal virtual void Update()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            // Move Enemy from current waypoint to the next one using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               movementSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards then waypointIndex is increased by 1
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            
        }
        else if (waypointIndex == waypoints.Count)
        {
            PanelEscaped.EscapedFish(this);
            Destroy(this);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCoordinator : MonoBehaviour
{

    public static GameObject buildMenu;
    public static GameObject towerMenu;

    private void Awake()
    {
        buildMenu = GameObject.Find("BuildMenu");
        towerMenu = GameObject.Find("TowerSelectedMenu");
    }

    internal static void switchMenu(bool init)
    {

        if (buildMenu.activeInHierarchy && !init)
        {
            buildMenu.SetActive(false);
            towerMenu.SetActive(true);
        }
        else
        {
            buildMenu.SetActive(true);
            towerMenu.SetActive(false);
        }
    }

    void Start() { switchMenu(true); }

    void Update() {}
}

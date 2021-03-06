﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomSelection : MonoBehaviour
{
    [SerializeField] Text SelectionTimerText;

    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public Sprite Sprite5;
    public Sprite Sprite6;
    public Sprite Sprite7;
    public Sprite Sprite8;

    public Button Button1;
    public Button Button2;
    public Button Button3;


    private int firsttower;
    private int secondtower;
    private int thirdtower;

    private float selectionTimer = 10f;
    public GameObject SelectionUI;
    public GameObject PlacingTower;
    public GameObject PauseUI;
    public GameObject QuitUI;

    void OnEnable()
    {
        PlacingTower.SetActive(false);
        PauseUI.SetActive(false);
        QuitUI.SetActive(false);
        TowerList();
        SetUpButtonImage(ref Button1, firsttower);
        SetUpButtonImage(ref Button2, secondtower);
        SetUpButtonImage(ref Button3, thirdtower);

    }
    
    void OnDisable()
    {
        PlacingTower.SetActive(true);
        PauseUI.SetActive(true);
        QuitUI.SetActive(true);
    }

    void Update()
    {
        Debug.Log("Selection is called ");

        selectionTimer -= Time.deltaTime;
        SelectionTimerText.text = Mathf.Round(selectionTimer).ToString();
        if (selectionTimer <= 0)
        {
            //select a random tower and exit the scene
            int TimeoutSelect = Random.Range(1, 3);
            switch(TimeoutSelect)
            {
                case 1:
                    TowerOnClick1();
                    break;
                case 2:
                    TowerOnClick2();
                    break;
                case 3:
                    TowerOnClick3();
                    break;
            }


            WaveSpawner.spawnchecker = 1;
            Debug.Log("Setting bool");
            SelectionUI.SetActive(false);
            selectionTimer = 10f;
        }
    }

    // ============================================================================================================

    private int RandNum()
    {
        int RandomNumber = Random.Range(1, 1000);
        return RandomNumber;
    }

    public int TowerSelect()
    {
        // Just for an example, Tower types are denoted from type 1 to type 3
        int TowerNumber = RandNum();
        if (TowerNumber > 0 && TowerNumber <= 100)  // Citgo 
        {                                                     
            return 1;

        }

        if (TowerNumber > 100 && TowerNumber <= 200) // Warren Tower 
        {                                            
            return 2;
        }


        if (TowerNumber > 200 && TowerNumber <= 300) // Photonics 
        {                                            
            return 3;
        }


        if (TowerNumber > 300 && TowerNumber <= 500) // PandaExpress 
        {                                            
            return 4;
        }


        if (TowerNumber > 500 && TowerNumber <= 550) // Kenmore Station 
        {                                            
            return 5;
        }


        if (TowerNumber > 550 && TowerNumber <= 750) // Fenway Turret 
        {                                            
            return 6;
        }

        if (TowerNumber > 750 && TowerNumber <= 900) // BrownStone 
        {                                            
            return 7;
        }

        else                    // Agganis Arena 10%
        {                                            
            return 8;
        }

    }

    void TowerList()   // Comparing them before putting them on selection
    {
        firsttower = TowerSelect();
        secondtower = TowerSelect();
        thirdtower = TowerSelect();
        while (secondtower == firsttower || secondtower == thirdtower)
        {
            secondtower = TowerSelect();
        }

        while (thirdtower == firsttower || thirdtower == secondtower)
        {
            thirdtower = TowerSelect();
        }

    }

    void SetUpButtonImage(ref Button Butt, int towernum) // function to setup the button
    {
        switch (towernum)
        {
            case 1:
                Butt.GetComponent<Image>().sprite = Sprite1;
                break;
            case 2:
                Butt.GetComponent<Image>().sprite = Sprite2;
                break;
            case 3:
                Butt.GetComponent<Image>().sprite = Sprite3;
                break;
            case 4:
                Butt.GetComponent<Image>().sprite = Sprite4;
                break;
            case 5:
                Butt.GetComponent<Image>().sprite = Sprite5;
                break;
            case 6:
                Butt.GetComponent<Image>().sprite = Sprite6;
                break;
            case 7:
                Butt.GetComponent<Image>().sprite = Sprite7;
                break;
            case 8:
                Butt.GetComponent<Image>().sprite = Sprite8;
                break;
        }


    }

    public void TowerOnClick1()
    {
        switch(firsttower)
        {
            case 1:
                BuildManager.TowerName = "Objects/Turrets/Tower";
                break;
            case 2:
                BuildManager.TowerName = "Objects/Turrets/WarrenTowers";
                break;
            case 3:
                BuildManager.TowerName = "Objects/Turrets/Photonics Tower";
                break;
            case 4:
                BuildManager.TowerName = "Objects/Turrets/PandaExpress";
                break;
            case 5:
                BuildManager.TowerName = "Objects/Turrets/KenmoreStation";
                break;
            case 6:
                BuildManager.TowerName = "Objects/Turrets/Fenway_Turret";
                break;
            case 7:
                BuildManager.TowerName = "Objects/Turrets/BrownStone";
                break;
            case 8:
                BuildManager.TowerName = "Objects/Turrets/AgganisArena";
                break;
        }
        WaveSpawner.spawnchecker = 1;
        Debug.Log("Setting bool");
        SelectionUI.SetActive(false);
        selectionTimer = 10f;
    }

    public void TowerOnClick2()
    {
        switch (secondtower)
        {
            case 1:
                BuildManager.TowerName = "Objects/Turrets/Tower";
                break;
            case 2:
                BuildManager.TowerName = "Objects/Turrets/WarrenTowers";
                break;
            case 3:
                BuildManager.TowerName = "Objects/Turrets/Photonics Tower";
                break;
            case 4:
                BuildManager.TowerName = "Objects/Turrets/PandaExpress";
                break;
            case 5:
                BuildManager.TowerName = "Objects/Turrets/KenmoreStation";
                break;
            case 6:
                BuildManager.TowerName = "Objects/Turrets/Fenway_Turret";
                break;
            case 7:
                BuildManager.TowerName = "Objects/Turrets/BrownStone";
                break;
            case 8:
                BuildManager.TowerName = "Objects/Turrets/AgganisArena";
                break;


        }
        WaveSpawner.spawnchecker = 1;
        Debug.Log("Setting bool");
        SelectionUI.SetActive(false);
        selectionTimer = 10f;
    }

    public void TowerOnClick3()
    {
        switch (thirdtower)
        {
            case 1:
                BuildManager.TowerName = "Objects/Turrets/Tower";
                break;
            case 2:
                BuildManager.TowerName = "Objects/Turrets/WarrenTowers";
                break;
            case 3:
                BuildManager.TowerName = "Objects/Turrets/Photonics Tower";
                break;
            case 4:
                BuildManager.TowerName = "Objects/Turrets/PandaExpress";
                break;
            case 5:
                BuildManager.TowerName = "Objects/Turrets/KenmoreStation";
                break;
            case 6:
                BuildManager.TowerName = "Objects/Turrets/Fenway_Turret";
                break;
            case 7:
                BuildManager.TowerName = "Objects/Turrets/BrownStone";
                break;
            case 8:
                BuildManager.TowerName = "Objects/Turrets/AgganisArena";
                break;

        }
        WaveSpawner.spawnchecker = 1;
        Debug.Log("Setting bool");
        SelectionUI.SetActive(false);
        selectionTimer = 10f;
    }
}


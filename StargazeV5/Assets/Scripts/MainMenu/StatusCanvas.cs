using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusCanvas : MonoBehaviour
{
    public TextMeshProUGUI planetStatusUI01;
    public TextMeshProUGUI planetStatusUI02;
    public TextMeshProUGUI planetStatusUI03;
    public TextMeshProUGUI dysonStatusUI;
    int planetUnlocked;
    int dysonStatus;
    public GameObject endingUI;
    void Start()
    {
        planetUnlocked = GameManager.instance.GamePlanetUnlocked;
        dysonStatus = GameManager.instance.GameDysonStatus;

        if(planetUnlocked == 1){
            planetStatusUI01.text = "지구";
            planetStatusUI02.text = " ";
            planetStatusUI03.text = " ";
        }
        else if(planetUnlocked == 2){
            planetStatusUI01.text = "지구";
            planetStatusUI02.text = "화성";
            planetStatusUI03.text = " ";
        }
        else if(planetUnlocked == 3){
            planetStatusUI01.text = "지구";
            planetStatusUI02.text = "화성";
            planetStatusUI03.text = "수성";
        }
        else if(planetUnlocked == 3){
            planetStatusUI01.text = "?/?";
            planetStatusUI02.text = "?/?";
            planetStatusUI03.text = "?/?";
        }

        dysonStatusUI.text = dysonStatus.ToString() + "%";

        GameManager.instance.GameUpdate();
    }

        void Update()
    {
        planetUnlocked = GameManager.instance.GamePlanetUnlocked;
        dysonStatus = GameManager.instance.GameDysonStatus;

        if(planetUnlocked == 1){
            planetStatusUI01.text = "지구";
            planetStatusUI02.text = " ";
            planetStatusUI03.text = " ";
        }
        else if(planetUnlocked == 2){
            planetStatusUI01.text = "지구";
            planetStatusUI02.text = "화성";
            planetStatusUI03.text = " ";
        }
        else if(planetUnlocked == 3){
            planetStatusUI01.text = "지구";
            planetStatusUI02.text = "화성";
            planetStatusUI03.text = "수성";
        }
        else if(planetUnlocked == 3){
            planetStatusUI01.text = "?/?";
            planetStatusUI02.text = "?/?";
            planetStatusUI03.text = "?/?";
        }
        
        dysonStatusUI.text = dysonStatus.ToString() + "%";

        if(GameManager.instance.GameDysonStatus == 100) endingUI.SetActive(true);
    }
}

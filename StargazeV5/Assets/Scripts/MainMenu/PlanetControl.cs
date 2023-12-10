using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetControl : MonoBehaviour
{
    public GameObject EarthControl;
    public GameObject MarsControl;
    public GameObject MercuryControl;

    private void Update() {
        if(GameManager.instance.GamePlanetUnlocked == 1){
            EarthControl.SetActive(false);
            MarsControl.SetActive(true);
            MercuryControl.SetActive(true);
        }
        else if(GameManager.instance.GamePlanetUnlocked == 2){
            EarthControl.SetActive(true);
            MarsControl.SetActive(false);
            MercuryControl.SetActive(true);
        }
        else if(GameManager.instance.GamePlanetUnlocked == 3){
            EarthControl.SetActive(true);
            MarsControl.SetActive(true);
            MercuryControl.SetActive(false);
        }
    }
}

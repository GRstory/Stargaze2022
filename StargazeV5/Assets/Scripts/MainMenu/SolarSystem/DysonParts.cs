using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DysonParts : MonoBehaviour
{
    public GameObject[] dysonParts;

    private void Update() {
        if(GameManager.instance.GameDysonStatus == 10){
            dysonParts[0].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 20){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 30){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
            dysonParts[2].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 40){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
            dysonParts[2].SetActive(true);
            dysonParts[3].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 50){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
            dysonParts[2].SetActive(true);
            dysonParts[3].SetActive(true);
            dysonParts[4].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 60){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
            dysonParts[2].SetActive(true);
            dysonParts[3].SetActive(true);
            dysonParts[4].SetActive(true);
            dysonParts[5].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 70){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
            dysonParts[2].SetActive(true);
            dysonParts[3].SetActive(true);
            dysonParts[4].SetActive(true);
            dysonParts[5].SetActive(true);
            dysonParts[6].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 80){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
            dysonParts[2].SetActive(true);
            dysonParts[3].SetActive(true);
            dysonParts[4].SetActive(true);
            dysonParts[5].SetActive(true);
            dysonParts[6].SetActive(true);
            dysonParts[7].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 90){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
            dysonParts[2].SetActive(true);
            dysonParts[3].SetActive(true);
            dysonParts[4].SetActive(true);
            dysonParts[5].SetActive(true);
            dysonParts[6].SetActive(true);
            dysonParts[7].SetActive(true);
            dysonParts[8].SetActive(true);
        }
        if(GameManager.instance.GameDysonStatus == 100){
            dysonParts[0].SetActive(true);
            dysonParts[1].SetActive(true);
            dysonParts[2].SetActive(true);
            dysonParts[3].SetActive(true);
            dysonParts[4].SetActive(true);
            dysonParts[5].SetActive(true);
            dysonParts[6].SetActive(true);
            dysonParts[7].SetActive(true);
            dysonParts[8].SetActive(true);
            dysonParts[9].SetActive(true);
        }
    }
}

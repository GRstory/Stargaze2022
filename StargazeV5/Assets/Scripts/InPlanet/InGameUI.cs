using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InGameUI : MonoBehaviour
{
    public GameObject bluePrintUI;
    public GameObject techTreeUI;
    public GameObject inventoryUI;
    public GameObject prologueUI;
    public GameObject rocketUI;
    public static int buttonReturn = 0;

    public static void ReturnBluePrint(string text){
        //Debug.Log("ReturnBluePrint() working");
        if(text == "Btn_Slot001"){
            buttonReturn = 1;
        }
        else if(text == "Btn_Slot002"){
            buttonReturn = 2;
        }
        else if(text == "Btn_Slot003"){
            buttonReturn = 3;
        }
        else if(text == "Btn_Slot004"){
            buttonReturn = 4;
        }
        else if(text == "Btn_Slot005"){
            buttonReturn = 5;
        }
        else if(text == "Btn_Slot006"){
            buttonReturn = 6;
        }
        else if(text == "Btn_Slot007"){
            buttonReturn = 7;
        }
        else if(text == "Btn_Slot008"){
            buttonReturn = 8;
        }
    }

    public void BluePrintUI(){
        bluePrintUI.SetActive(true);
    }

    public void BluePrintUIOff(){
        bluePrintUI.SetActive(false);
    }

    public void TechTreeUI(){
        techTreeUI.SetActive(true);
    }

    public void TechTreeUIOff(){
        techTreeUI.SetActive(false);
    }

    public void InventoryUI(){
        inventoryUI.SetActive(true);
    }
    public void InventoryUIOff(){
        inventoryUI.SetActive(false);
    }

    public void PrologueUI(){
        prologueUI.SetActive(true);
    }
    public void PrologueUIOff(){
        prologueUI.SetActive(false);
    }
    public void rocketUION(){
        rocketUI.SetActive(true);
    }
    public void rocketUIOFF(){
        rocketUI.SetActive(false);
    }
}

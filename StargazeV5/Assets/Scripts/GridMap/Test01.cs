using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Test01 : MonoBehaviour{
    private Grid grid;
    private int gridValue;
    private string bluePrintSelect;

    private void Start()
    {
        grid = new Grid(128, 128, 10.0f, new Vector3(0, 0));
    }
    
    public void ClickBlueprintSelect(){
        bluePrintSelect = EventSystem.current.currentSelectedGameObject.name;
        InGameUI.ReturnBluePrint(bluePrintSelect);
        Debug.Log(bluePrintSelect);
        gridValue = InGameUI.buttonReturn;
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            grid.SetValue(Grid.GetMousePosition(Input.mousePosition, Camera.main), gridValue);
        }
        if(Input.GetMouseButtonDown(1)){
            Debug.Log(grid.GetValue(Grid.GetMousePosition(Input.mousePosition, Camera.main)));
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Space");
        }
    }
}

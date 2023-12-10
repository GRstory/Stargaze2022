using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject imageLogoBig;
    public GameObject imageLogoSmall;
    public GameObject imageGrid;
    public GameObject touchObject;
    public GameObject buttonSetUI;
    public GameObject spaceStatusUI;
    public GameObject mainSettingUI;
    public GameObject initSettingUI;
    public GameObject helpUI;
    public GameObject endingUI;

    private void OnEnable() {
        try{
            if(GameManager.instance.IsGameStart == true){
                MainGameStart();
            }
        }
        catch{
            Debug.Log("게임 시작");
        }

    }

    public void InitSettingUION(){ //게임 시작 버튼 > InitSettingUI ON
        buttonSetUI.SetActive(false);
        initSettingUI.SetActive(true);

        GameManager.instance.IsGameStart = true;
    }

    public void InitSettingUIOFF(){ // InitSettingUI OFF
        Debug.Log("최초 설정");
        buttonSetUI.SetActive(true);
        initSettingUI.SetActive(false);
        GameManager.instance.IsGameStart = false;
    }
    
    public void MainGameStart(){ // InitSettingUI save > MainGameStart
        buttonSetUI.SetActive(false);
        initSettingUI.SetActive(false);
        imageLogoBig.SetActive(false);
        imageLogoSmall.SetActive(true);
        imageGrid.SetActive(true);
        touchObject.SetActive(false);
        spaceStatusUI.SetActive(true);
        helpUI.SetActive(true);
    }

    public void MainMenuSettingUION(){ // MainMenuSettingUI ON
        buttonSetUI.SetActive(false);
        mainSettingUI.SetActive(true);
    }
    
    public void MainMenuSettingUIOFF(){ // MainMenuSettingUI OFF
        if(GameManager.instance.IsGameStart == true){
            buttonSetUI.SetActive(false);
            mainSettingUI.SetActive(false);
        }
        else{
            buttonSetUI.SetActive(true);
            mainSettingUI.SetActive(false);
        }
    }

    public void MainMenuHelpUION(){
        helpUI.SetActive(true);
    }

    public void MainMenuHelpUIOFF(){
        helpUI.SetActive(false);
    }

    public void MainEndingUIClick(){
        SceneManager.LoadScene("EndingScene");
    }


    public void MainMenuExit(){
        Debug.Log("게임 종료");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
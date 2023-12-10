using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuSetting : MonoBehaviour
{
    FullScreenMode screenMode;
    public int resolutionNum;
    public TMPro.TMP_Dropdown resolutionDropdown;
    public Toggle fullScreenButton;
    List<Resolution> resolutions = new List<Resolution>();
    private void Start() {
        InitUI();
    }

    void InitUI(){
        for(int i = 0; i<Screen.resolutions.Length; i++){
            if(Screen.resolutions[i].refreshRate == 144){
                resolutions.Add(Screen.resolutions[i]);
            }
        }
        resolutionDropdown.options.Clear();

        int optionNum = 0;

        foreach(Resolution item in resolutions){
            TMPro.TMP_Dropdown.OptionData option = new TMPro.TMP_Dropdown.OptionData();
            option.text = item.width + "x" + item.height + " " + item.refreshRate + "hz";
            resolutionDropdown.options.Add(option);

            //Debug.Log(item.width + "x" + item.height + "" + item.refreshRate + "hz");
            if(item.width == Screen.width && item.height == Screen.height){
                resolutionDropdown.value = optionNum;
                optionNum++;
            }
        }

        resolutionDropdown.RefreshShownValue();
        fullScreenButton.isOn = Screen.fullScreenMode.Equals(FullScreenMode.FullScreenWindow) ? true : false;
    }

    public void DropdownOptionChange(int x){
        resolutionNum = x;
    }

    public void SaveButton(){
        Screen.SetResolution(resolutions[resolutionNum].width, resolutions[resolutionNum].height, screenMode);
    }
    public void FullScreenButton(bool x){
        screenMode = x ? FullScreenMode.FullScreenWindow: FullScreenMode.Windowed;
    }
}

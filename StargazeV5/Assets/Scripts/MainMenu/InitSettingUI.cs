using UnityEngine;
using System;
using TMPro;

public class InitSettingUI : MonoBehaviour
{
    public TMP_InputField inputSeedUI;
    public TMP_InputField inputOffsetX;
    public TMP_InputField inputOffsetY;
    public void InputSeed(){
        GameManager.instance.GameSeed1 = Int32.Parse(inputSeedUI.text);
        GameManager.instance.GameSeed2 = GameManager.instance.GameSeed1 + 1;
        GameManager.instance.GameSeed3 = GameManager.instance.GameSeed1 + 2;

        GameManager.instance.GameOffetX = float.Parse(inputOffsetX.text);
        GameManager.instance.GameOffetY = float.Parse(inputOffsetY.text);
    }
}

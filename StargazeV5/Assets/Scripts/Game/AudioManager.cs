using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    
    void Start() {
        slider.value=PlayerPrefs.GetFloat("BackgroundMusic", 0.75f);    
    }
    public void SetLevel(float sliderValue){
        mixer.SetFloat("BackgroundMusic", Mathf.Log10(sliderValue)*20);
        PlayerPrefs.SetFloat("BackgroundMusic", sliderValue);
    }

}

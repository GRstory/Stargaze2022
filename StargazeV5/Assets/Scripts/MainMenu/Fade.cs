using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour {
    //private Image image;
    public Image image;
    [SerializeField]
    [Range(0.01f, 10f)]
    private float loadTime = 2;

    private void Awake() {
        //image = GetComponent<Image>();
        StartCoroutine(StartFade(1, 0));
    }

    private IEnumerator StartFade(float start, float end){
        float currentTime = 0.0f;
        float percent = 0.0f;

        while(percent < 1.0f){
            currentTime += Time.deltaTime;
            percent = currentTime / loadTime;

            Color color = image.color;
            color.a = Mathf.Lerp(start, end, percent);
            image.color = color;

            yield return null;
        }
    }
}


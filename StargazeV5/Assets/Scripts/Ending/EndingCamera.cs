using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingCamera : MonoBehaviour
{
    public Camera camera2D;
    public Image fadeOut;
    public Image fadein;
    public GameObject endUI;
    public GameObject logo;
    private float loadTimeIn = 2; //지속시간
    private float loadTimeOut = 2; //지속시간
    private Vector3 cameraLimit = new Vector3(0, 0, -500);
    private Vector3 cameraLimit2 = new Vector3(0, 0, -700);

    private void Awake() {
        StartCoroutine(FadeIn(1, 0));
    }
    private void Update() {
        MoveCamera();
    }

    private IEnumerator FadeOut(float start, float end){
        float currentTime = 1.0f;
        float percent = 1.0f;

        while(percent > 0.0f){
            currentTime -= Time.deltaTime;
            percent = currentTime / loadTimeOut;

            Color color = fadeOut.color;
            color.a = Mathf.Lerp(start, end, percent);
            fadeOut.color = color;

            yield return null;
        }
    }
    private IEnumerator FadeIn(float start, float end){
        float currentTime = 0.0f;
        float percent = 0.0f;

        while(percent < 1.0f){
            currentTime += Time.deltaTime;
            percent = currentTime / loadTimeIn;

            Color color = fadeOut.color;
            color.a = Mathf.Lerp(start, end, percent);
            fadeOut.color = color;

            yield return null;
        }
    }
    private void MoveCamera(){
        if(camera2D.orthographicSize < 8) camera2D.orthographicSize += 0.0030f;
        else if(camera2D.orthographicSize < 12) camera2D.orthographicSize += 0.0020f;
        else if(camera2D.orthographicSize < 16) camera2D.orthographicSize += 0.0013f;
        else if(camera2D.orthographicSize >= 16 && camera2D.orthographicSize < 17) {
            camera2D.orthographicSize += 0.0013f;
            StartCoroutine(FadeOut(1, 0));
        }
        else if(camera2D.orthographicSize >= 17){
            logo.SetActive(false);
            endUI.SetActive(true);
        }
    }
}

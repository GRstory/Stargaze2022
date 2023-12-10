using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class EarthClick : MonoBehaviour
{   public Image image;
    [SerializeField]
    [Range(0.01f, 10f)]
    private float loadTime = 2;

    void OnMouseDown() {
        FadeOut();
        Invoke("LoadEarth", 1.0f);
    }

    private void LoadEarth(){
        SceneManager.LoadScene("EarthScene");
    }
    
    private void FadeOut(){
        StartCoroutine(EndFade(1, 0));
    }

    private IEnumerator EndFade(float start, float end){
        float currentTime = 1.0f;
        float percent = 1.0f;

        while(percent > 0.0f){
            currentTime -= Time.deltaTime;
            percent = currentTime / loadTime;

            Color color = image.color;
            color.a = Mathf.Lerp(start, end, percent);
            image.color = color;

            yield return null;
        }
    }
}

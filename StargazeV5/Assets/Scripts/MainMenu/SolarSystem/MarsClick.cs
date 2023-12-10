using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MarsClick : MonoBehaviour
{   public Image image;
    [SerializeField]
    [Range(0.01f, 10f)]
    private float loadTime = 2;

    void OnMouseDown() {
        FadeOut();
        Invoke("LoadMars", 1.0f);
    }

    private void LoadMars(){
        SceneManager.LoadScene("MarsScene");
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

